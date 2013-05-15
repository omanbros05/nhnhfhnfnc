using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;


namespace NBear.Mapping
{
    public class ConfigurationManager
    {
        static Dictionary<string, Type> typeAliases = new Dictionary<string, Type>();
        static Dictionary<Type, Type> defaultInitTypes = new Dictionary<Type, Type>();
        static Dictionary<string, ObjectMapper> objectMappers = new Dictionary<string, ObjectMapper>();

        private static bool isInited = false;
        private static object lockHelper = new object();

        static ConfigurationManager()
        {
            if (!isInited)
            {
                lock (lockHelper)
                {
                    if (!isInited)
                    {
                        Init();
                        isInited = true;
                    }
                }
            }
        }

        #region Init config

        static void Init()
        {
            NBearMappingSection section = System.Configuration.ConfigurationManager.GetSection("nbearMapping") as NBearMappingSection;
            if (section != null)
            {
                foreach (string key in section.Includes.AllKeys)
                {
                    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, section.Includes[key].Value);

                    NBearMappingConfiguration config = new NBearMappingConfiguration(filePath);
                    if (config.TypeAliases != null)
                    {
                        AddTypeAliases(config.TypeAliases);
                    }
                    if (config.DefaultInitTypes != null)
                    {
                        AddDefaultInitTypes(config.DefaultInitTypes);
                    }
                    //if (config.Getters != null)
                    //{
                    //    RegisterGetter(config.Getters);
                    //}
                    //if (config.Setters != null)
                    //{
                    //    RegisterSetter(config.Setters);
                    //}
                    if (config.ObjectMappgers != null)
                    {
                        AddObjectMapper(config.ObjectMappgers);
                    }
                }
            }
        }

        /// <summary>
        /// 添加ObjectMapper配置
        /// </summary>
        /// <param name="configs">The configs.</param>
        private static void AddObjectMapper(List<ObjectMapperConfig> configs)
        {
            foreach (ObjectMapperConfig mapperConfig in configs)
            {
                Type inputType = GetType(mapperConfig.InputType);
                Type outputType = GetType(mapperConfig.OutputType);
                Check.Require(inputType != null, string.Format("type {0} could not be found !", mapperConfig.InputType));
                Check.Require(outputType != null, string.Format("type {0} could not be found !", mapperConfig.OutputType));
                ObjectMapper defaultViewMapper = null;
                foreach (ViewConfig view in mapperConfig.Views)
                {
                    Type initType = GetInitType(inputType);
                    if (!string.IsNullOrEmpty(view.InitType))
                    {
                        initType = GetType(view.InitType);
                    }

                    ObjectMapper objectMapper = new ObjectMapper(inputType, outputType, initType, view.MappingSpecifiedOnly);

                    if (view.Properties != null)
                    {
                        foreach (AddPropertySetting property in view.Properties.Adds)
                        {
                            objectMapper.AddCustomMappingName(property.SrcName, property.DestName);
                            if (property.Order > 0)
                            {
                                objectMapper.AddMappingOrder(property.DestName, property.Order);
                            }                            
                        }
                    }

                    if (view.IgnoreProperties != null)
                    {
                        foreach (AddIgnorePropertySetting ignoreProperty in view.IgnoreProperties.Adds)
                        {
                            objectMapper.AddIgnoreMappingName(ignoreProperty.DestName);
                        }
                    }

                    if (view.CustomMappingInterface != null && view.CustomMappingInterface.Adds != null)
                    {
                        foreach (AddCustomMappingInterface mappingFunctionSetting in view.CustomMappingInterface.Adds)
                        {
                            Type type = GetType(mappingFunctionSetting.ClassName);
                            ICustomObjectMemberMapping customMapping = (ICustomObjectMemberMapping)Activator.CreateInstance(type, null);
                            objectMapper.AddCustomMapping(customMapping);

                        }
                    }
                    if (mapperConfig.DefaultView == view.ViewName || string.IsNullOrEmpty(mapperConfig.DefaultView))
                    {
                        defaultViewMapper = objectMapper;
                    }
                    objectMappers.Add(GetObjectMapperKey(inputType, outputType, view.ViewName), objectMapper);
                }
                if (defaultViewMapper == null)
                {
                    defaultViewMapper = new ObjectMapper(inputType, outputType, null);
                }
                objectMappers.Add(GetObjectMapperKey(inputType, outputType, null), defaultViewMapper);
            }
        }

        ///// <summary>
        ///// 注册member setter
        ///// 	<remark>abu 2007-11-16 10:36</remark>
        ///// </summary>
        ///// <param name="config">The config.</param>
        //private static void RegisterSetter(SettersConfig config)
        //{
        //    foreach (RemoveTypeSetting remove in config.Removes)
        //    {
        //        Type type = GetType(remove.Type);
        //        Check.Require(type != null, string.Format("type {0} could not be found !", remove.Type));
        //        MemberSetterFactory.RemoveMemberSetter(type);
        //    }
        //    foreach (AddSetterSetting add in config.Adds)
        //    {
        //        Type type = GetType(add.Type);
        //        Type setter = GetType(add.Setter);
        //        Check.Require(type != null, string.Format("type {0} could not be found !", add.Type));
        //        Check.Require(setter != null, string.Format("type {0} could not be found !", add.Setter));
        //        MemberSetterFactory.RegisterMemberSetter(type, setter, add.AsSingleton);
        //    }
        //}

        ///// <summary>
        ///// 注册member getter
        ///// 	<remark>abu 2007-11-16 10:36</remark>
        ///// </summary>
        ///// <param name="config">The config.</param>
        //private static void RegisterGetter(GettersConfig config)
        //{
        //    foreach (RemoveTypeSetting remove in config.Removes)
        //    {
        //        Type type = GetType(remove.Type);
        //        Check.Require(type != null, string.Format("type {0} could not be found !", remove.Type));
        //        MemberGetterFactory.RemoveMemberGetter(type);
        //    }
        //    foreach (AddGetterSetting add in config.Adds)
        //    {
        //        Type type = GetType(add.Type);
        //        Type getter = GetType(add.Getter);
        //        Check.Require(type != null, string.Format("type {0} could not be found !", add.Type));
        //        Check.Require(getter != null, string.Format("type {0} could not be found !", add.Getter));
        //        MemberGetterFactory.RegisterMemberGetter(type, getter, add.AsSingleton);
        //    }
        //}

        /// <summary>
        /// 添加默认初始化类
        /// 	<remark>abu 2007-11-16 10:27</remark>
        /// </summary>
        /// <param name="config">The config.</param>
        private static void AddDefaultInitTypes(DefaultInitTypesConfig config)
        {
            foreach (RemoveTypeSetting remove in config.Removes)
            {
                Type type = GetType(remove.Type);
                Check.Require(type != null, string.Format("type {0} could not be found !", remove.Type));
            }
            foreach (AddDefaultInitTypeSetting defaultInitType in config.Adds)
            {
                Type type = GetType(defaultInitType.Type);
                Type initType = GetType(defaultInitType.InitType);
                Check.Require(type != null, string.Format("type {0} could not be found !", defaultInitType.Type));
                Check.Require(initType != null, string.Format("type {0} could not be found !", defaultInitType.InitType));
                defaultInitTypes.Add(type, initType);
            }
        }

        /// <summary>
        /// 添加类型别名
        /// 	<remark>abu 2007-11-16 10:27</remark>
        /// </summary>
        /// <param name="config">The config.</param>
        private static void AddTypeAliases(TypeAliasesConfig config)
        {
            foreach (RemoveTypeSetting remove in config.Removes)
            {
                if (typeAliases.ContainsKey(remove.Type))
                {
                    typeAliases.Remove(remove.Type);
                }
            }
            foreach (AddTypeAliasSetting typeAlias in config.Adds)
            {
                Type type = GetType(typeAlias.FullTypeName);
                Check.Require(type != null, string.Format("type {0} could not be found !", typeAlias.FullTypeName));
                typeAliases.Add(typeAlias.Type, type);
            }
        }

        #endregion

        private static string GetObjectMapperKey(Type inputType, Type outputType, string viewName)
        {
            Check.Require(inputType, "inputType", Check.NotNull);
            Check.Require(outputType, "inputType", Check.NotNull);

            string key = string.Format("inputType-{0}-outputType-{1}", inputType.FullName, outputType.FullName);
            if (!string.IsNullOrEmpty(viewName))
            {
                key += "-ViewName-" + viewName;
            }
            return key;
        }
        internal static Type GetType(string typeName)
        {
            Type type = CommonUtils.GetType(typeName);
            if (type == null)
            {
                if (typeAliases.ContainsKey(typeName))
                {
                    type = typeAliases[typeName];
                }
            }
            return type;
        }

        internal static Type GetInitType(Type type)
        {
            if (defaultInitTypes.ContainsKey(type))
            {
                return defaultInitTypes[type];
            }
            return null;
        }

        internal static ObjectMapper GetObjectMapper(Type inputType, Type outputType, string viewName)
        {
            string key = GetObjectMapperKey(inputType, outputType, viewName);
            if (objectMappers.ContainsKey(key))
            {
                return objectMappers[key];
            }
            if (!string.IsNullOrEmpty(viewName))
            {
                throw new NullReferenceException(string.Format("InputType '{0}',OutputType '{1}' with ViewName '{2}' config could not be found",
                    inputType.Name, outputType.Name, viewName));
            }
            return null;
        }
    }

    /// <summary>
    /// The nbear mapping configuration section.
    /// </summary>
    public class NBearMappingSection : ConfigurationSection
    {

        /// <summary>
        /// Gets or sets the includes.
        /// </summary>
        /// <value>The includes.</value>
        [ConfigurationProperty("includes", IsRequired = true, IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(KeyValueConfigurationCollection))]
        public KeyValueConfigurationCollection Includes
        {
            get
            {
                return (KeyValueConfigurationCollection)this["includes"];
            }
            set
            {
                this["includes"] = value;
            }
        }
    }

    #region Configuration class
    /// <summary>
    /// 	<remark>abu 2007-11-16 9:46</remark>
    /// </summary>
    /// <typeparam name="RemoveSettingType">The type of the emove setting type.</typeparam>
    /// <typeparam name="AddSettingType">The type of the dd setting type.</typeparam>
    public abstract class SettingsConfig<RemoveSettingType, AddSettingType>
        where RemoveSettingType : SettingConfig
        where AddSettingType : SettingConfig
    {
        public SettingsConfig(XmlNode xmlNode)
        {
            foreach (XmlNode node in xmlNode.ChildNodes)
            {
                if (node.Name == "add")
                {
                    adds.Add((AddSettingType)Activator.CreateInstance(typeof(AddSettingType), node));
                }
                if (node.Name == "remove")
                {
                    removes.Add((RemoveSettingType)Activator.CreateInstance(typeof(RemoveSettingType), node));
                }
            }
        }
        private List<RemoveSettingType> removes = new List<RemoveSettingType>();

        /// <summary>
        /// </summary>
        /// <value></value>
        public List<RemoveSettingType> Removes
        {
            get { return removes; }
            set { removes = value; }
        }
        private List<AddSettingType> adds = new List<AddSettingType>();

        /// <summary>
        /// </summary>
        /// <value></value>
        public List<AddSettingType> Adds
        {
            get { return adds; }
            set { adds = value; }
        }
    }

    /// <summary>
    /// </summary>
    public class SettingConfig
    {
        public SettingConfig(XmlNode xmlNode)
        {
            this.node = xmlNode;
            attributes = AttributeToNameValueCollection(xmlNode.Attributes);
        }
        private XmlNode node;
        /// <summary>
        /// </summary>
        /// <value></value>
        public XmlNode XmlNode
        {
            get { return node; }
        }

        private NameValueCollection attributes;
        protected NameValueCollection Attributes
        {
            get { return attributes; }
        }

        public static NameValueCollection AttributeToNameValueCollection(XmlAttributeCollection attributes)
        {
            NameValueCollection nameValue = new NameValueCollection();
            foreach (XmlAttribute att in attributes)
            {
                nameValue.Add(att.Name, att.Value);
            }
            return nameValue;
        }

    }

    public class RemoveTypeSetting : SettingConfig
    {
        public RemoveTypeSetting(XmlNode node)
            : base(node)
        {
            Check.Require(Type, "type attribute", Check.NotNullOrEmpty);
        }
        public string Type
        {
            get { return base.Attributes["type"]; }
        }
    }

    public class AddTypeAliasSetting : SettingConfig
    {
        public AddTypeAliasSetting(XmlNode node)
            : base(node)
        {
            Check.Require(Type, "type attribute", Check.NotNullOrEmpty);
            Check.Require(FullTypeName, "fullTypeName attribute", Check.NotNullOrEmpty);
        }
        public string Type
        {
            get { return base.Attributes["type"]; }
        }
        public string FullTypeName
        {
            get { return base.Attributes["fullTypeName"]; }
        }
    }

    public class TypeAliasesConfig : SettingsConfig<RemoveTypeSetting, AddTypeAliasSetting>
    {
        public TypeAliasesConfig(XmlNode node)
            : base(node)
        {
        }
    }

    public class AddDefaultInitTypeSetting : SettingConfig
    {
        public AddDefaultInitTypeSetting(XmlNode node)
            : base(node)
        {
            Check.Require(Type, "type attribute", Check.NotNullOrEmpty);
            Check.Require(InitType, "initType attribute", Check.NotNullOrEmpty);
        }
        public string Type
        {
            get { return base.Attributes["type"]; }
        }
        public string InitType
        {
            get { return base.Attributes["initType"]; }
        }
    }

    public class DefaultInitTypesConfig : SettingsConfig<RemoveTypeSetting, AddDefaultInitTypeSetting>
    {
        public DefaultInitTypesConfig(XmlNode node)
            : base(node)
        {
        }
    }

    public class AddGetterSetting : SettingConfig
    {
        public AddGetterSetting(XmlNode node)
            : base(node)
        {
            Check.Require(Type, "type attribute", Check.NotNullOrEmpty);
            Check.Require(Getter, "getter attribute", Check.NotNullOrEmpty);
        }
        public string Type
        {
            get { return base.Attributes["type"]; }
        }
        public string Getter
        {
            get { return base.Attributes["getter"]; }
        }
        public bool AsSingleton
        {
            get
            {
                string asSingleton = base.Attributes["asSingleton"];
                if (!string.IsNullOrEmpty(asSingleton))
                {
                    return bool.Parse(asSingleton);
                }
                return false;
            }
        }
    }

    public class AddPropertySetting : SettingConfig
    {
        public AddPropertySetting(XmlNode node)
            : base(node)
        {
            Check.Require(SrcName, "srcName attribute", Check.NotNullOrEmpty);
            Check.Require(DestName, "destName attribute", Check.NotNullOrEmpty);
        }
        public string SrcName
        {
            get { return base.Attributes["srcName"]; }
        }
        public string DestName
        {
            get { return base.Attributes["destName"]; }
        }
        public int Order
        {
            get
            {
                string order = base.Attributes["order"];
                if (!string.IsNullOrEmpty(order))
                {
                    return int.Parse(order);
                }
                return -1;
            }
        }
    }

    public class PropertiesConfig : SettingsConfig<SettingConfig, AddPropertySetting>
    {
        public PropertiesConfig(XmlNode node)
            : base(node)
        {
        }
    }

    public class AddIgnorePropertySetting : SettingConfig
    {
        public AddIgnorePropertySetting(XmlNode node)
            : base(node)
        {
            Check.Require(DestName, "name attribute", Check.NotNullOrEmpty);
        }
        public string DestName
        {
            get { return base.Attributes["destName"]; }
        }
    }

    public class IgnorePropertiesConfig : SettingsConfig<SettingConfig, AddIgnorePropertySetting>
    {
        public IgnorePropertiesConfig(XmlNode node)
            : base(node)
        {
        }
    }

    public class AddCustomMappingInterface : SettingConfig
    {
        public AddCustomMappingInterface(XmlNode node)
            : base(node)
        {
            Check.Require(ClassName, "className attribute", Check.NotNullOrEmpty);
        }
        public string ClassName
        {
            get { return base.Attributes["className"]; }
        }
    }

    public class CustomMappingInterfaces : SettingsConfig<RemoveTypeSetting, AddCustomMappingInterface>
    {
        public CustomMappingInterfaces(XmlNode node) : base(node) { }
    }

    public class ObjectMapperConfig
    {
        public ObjectMapperConfig(XmlNode node)
        {
            NameValueCollection attributes = SettingConfig.AttributeToNameValueCollection(node.Attributes);
            inputType = attributes["inputType"];
            outputType = attributes["outputType"];

            Check.Require(inputType, "inputType", Check.NotNullOrEmpty);
            Check.Require(inputType, "outputType", Check.NotNullOrEmpty);

            XmlNode viewNodes = node.SelectSingleNode("views");
            if (viewNodes != null)
            {
                if (viewNodes.Attributes["defaultView"] != null)
                {
                    defaultView = viewNodes.Attributes["defaultView"].Value;
                }
                foreach (XmlNode viewNode in viewNodes.ChildNodes)
                {
                    if (viewNode.Name == "view")
                    {
                        views.Add(new ViewConfig(viewNode));
                    }
                }
            }
        }
        private string defaultView;
        public string DefaultView
        {
            get { return defaultView; }
        }

        private List<ViewConfig> views = new List<ViewConfig>();
        public List<ViewConfig> Views
        {
            get { return views; }
        }


        private string inputType;
        /// <summary>
        /// 输入类型
        /// </summary>
        /// <value></value>
        public string InputType
        {
            get { return inputType; }
        }

        private string outputType;
        public string OutputType
        {
            get { return outputType; }
        }
    }

    public class ViewConfig
    {
        public ViewConfig(XmlNode node)
        {
            NameValueCollection attributes = SettingConfig.AttributeToNameValueCollection(node.Attributes);
            string strMappingSpecifiedOnly = attributes["mappingSpecifiedOnly"];
            if (!string.IsNullOrEmpty(strMappingSpecifiedOnly))
            {
                mappingSpecifiedOnly = bool.Parse(strMappingSpecifiedOnly);
            }
            initType = attributes["initType"];
            viewName = attributes["name"];

            Check.Require(viewName, "viewName", Check.NotNullOrEmpty);

            XmlNode propertiesNode = node.SelectSingleNode("properties");
            if (propertiesNode != null)
            {
                properties = new PropertiesConfig(propertiesNode);
            }
            XmlNode ignorePropertiesNode = node.SelectSingleNode("ignoreProperties");
            //当不是显式映射时才读取忽略字段
            if (ignorePropertiesNode != null && !mappingSpecifiedOnly)
            {
                ignoreProperties = new IgnorePropertiesConfig(ignorePropertiesNode);
            }
            XmlNode customMappingNode = node.SelectSingleNode("customMapping");
            if (customMappingNode != null)
            {
                customMappingInterfaces = new CustomMappingInterfaces(customMappingNode);
            }
        }
        private PropertiesConfig properties;
        public PropertiesConfig Properties
        {
            get { return properties; }
        }
        private IgnorePropertiesConfig ignoreProperties;
        public IgnorePropertiesConfig IgnoreProperties
        {
            get { return ignoreProperties; }
        }
        private CustomMappingInterfaces customMappingInterfaces;
        public CustomMappingInterfaces CustomMappingInterface
        {
            get { return customMappingInterfaces; }
        }

        private bool mappingSpecifiedOnly;
        public bool MappingSpecifiedOnly
        {
            get { return mappingSpecifiedOnly; }
        }
        private string initType;

        public string InitType
        {
            get { return initType; }
        }

        private string viewName;
        public string ViewName
        {
            get { return viewName; }
        }

    }

    public class NBearMappingConfiguration
    {
        public NBearMappingConfiguration(string fileName)
        {
            XmlDocument dom = new XmlDocument();
            dom.Load(fileName);
            ParseXml(dom.SelectSingleNode("NBear.Mapping"));
        }

        private void ParseXml(XmlNode node)
        {
            XmlNode typeAliasesNode = node.SelectSingleNode("typeAliases");
            if (typeAliasesNode != null)
            {
                typeAliases = new TypeAliasesConfig(typeAliasesNode);
            }
            XmlNode defaultInitTypesNode = node.SelectSingleNode("defaultInitTypes");
            if (defaultInitTypesNode != null)
            {
                defaultInitTypes = new DefaultInitTypesConfig(defaultInitTypesNode);
            }

            XmlNode mappingsNode = node.SelectSingleNode("mappings");
            if (mappingsNode != null)
            {
                foreach (XmlNode objectNode in mappingsNode.ChildNodes)
                {
                    if (objectNode.Name == "object")
                    {
                        objectMappers.Add(new ObjectMapperConfig(objectNode));
                    }
                }
            }
        }

        private TypeAliasesConfig typeAliases;
        public TypeAliasesConfig TypeAliases
        {
            get { return typeAliases; }
        }
        private DefaultInitTypesConfig defaultInitTypes;
        public DefaultInitTypesConfig DefaultInitTypes
        {
            get { return defaultInitTypes; }
        }

        private List<ObjectMapperConfig> objectMappers = new List<ObjectMapperConfig>();
        public List<ObjectMapperConfig> ObjectMappgers
        {
            get { return objectMappers; }
        }


    }
    #endregion
}
