using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.Globalization;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;

namespace NBearLite.Emit
{
    public enum Cmp
    {
        LessThan,
        EqualTo,
        LessThanOrEqualTo,
        GreaterThan,
        NotEqualTo,
        GreaterThanOrEqualTo
    }

    public class ArgBuilder
    {
        // Fields
        public Type ArgType;
        public int Index;

        // Methods
        public ArgBuilder(int index, Type argType)
        {
            this.Index = index;
            this.ArgType = argType;
        }
    }

    public class IfState
    {
        // Fields
        private Label elseBegin;
        private Label endIf;

        // Properties
        public Label ElseBegin
        {
            get
            {
                return this.elseBegin;
            }
            set
            {
                this.elseBegin = value;
            }
        }

        public Label EndIf
        {
            get
            {
                return this.endIf;
            }
            set
            {
                this.endIf = value;
            }
        }
    }

    public class SwitchState
    {
        // Fields
        private bool defaultDefined;
        private Label defaultLabel;
        private Label endOfSwitchLabel;

        // Methods
        public SwitchState(Label defaultLabel, Label endOfSwitchLabel)
        {
            this.defaultLabel = defaultLabel;
            this.endOfSwitchLabel = endOfSwitchLabel;
            this.defaultDefined = false;
        }

        // Properties
        public bool DefaultDefined
        {
            get
            {
                return this.defaultDefined;
            }
            set
            {
                this.defaultDefined = value;
            }
        }

        public Label DefaultLabel
        {
            get
            {
                return this.defaultLabel;
            }
        }

        public Label EndOfSwitchLabel
        {
            get
            {
                return this.endOfSwitchLabel;
            }
        }
    }

    public static class Globals
    {
        // Fields
        public const string ActualTypeLocalName = "ActualType";
        public const string ActualTypeNameAttribute = "Name";
        public const string ActualTypeNamespaceAttribute = "Namespace";
        public const string AddMethodName = "Add";
        public const string AddValueMethodName = "AddValue";
        public const string AnyTypeLocalName = "anyType";
        public const string ArrayPrefix = "ArrayOf";
        public const string ArraySizeLocalName = "Size";
        public const string ClrAssemblyLocalName = "Assembly";
        public const string ClrNamespaceProperty = "ClrNamespace";
        public const string ClrTypeLocalName = "Type";
        public const string CollectionsNamespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays";
        public const string ContextFieldName = "context";
        public const string CurrentPropertyName = "Current";
        public const string DataContractXmlNamespace = "http://schemas.datacontract.org/2004/07/System.Xml";
        public const string DataContractXsdBaseNamespace = "http://schemas.datacontract.org/2004/07/";
        private static Uri dataContractXsdBaseNamespaceUri;
        public const string DefaultClrNamespace = "GeneratedNamespace";
        public const bool DefaultEmitDefaultValue = true;
        public const string DefaultFieldSuffix = "Field";
        public const string DefaultGeneratedMember = "GeneratedMember";
        public const bool DefaultIsRequired = false;
        public const string DefaultMemberSuffix = "Member";
        public const int DefaultOrder = 0;
        public const string DefaultPropertySuffix = "Property";
        public const string DefaultTypeName = "GeneratedType";
        public const string DefaultValueLocalName = "DefaultValue";
        public const string ElementPrefix = "q";
        public const string EmitDefaultValueAttribute = "EmitDefaultValue";
        public const string EmitDefaultValueProperty = "EmitDefaultValue";
        private static object[] emptyObjectArray;
        private static Type[] emptyTypeArray;
        public const string EnumerationValueLocalName = "EnumerationValue";
        public const string EnumeratorFieldName = "enumerator";
        public const string ExportSchemaMethod = "ExportSchema";
        public const string ExtensionDataObjectFieldName = "extensionDataField";
        public const string ExtensionDataObjectPropertyName = "ExtensionData";
        public const string ExtensionDataSetExplicitMethod = "System.Runtime.Serialization.IExtensibleDataObject.set_ExtensionData";
        public const string ExtensionDataSetMethod = "set_ExtensionData";
        public const string False = "false";
        public const string GenericNameAttribute = "Name";
        public const string GenericNamespaceAttribute = "Namespace";
        public const string GenericParameterLocalName = "GenericParameter";
        public const string GenericParameterNestedLevelAttribute = "NestedLevel";
        public const string GenericTypeLocalName = "GenericType";
        public const string GetCurrentMethodName = "get_Current";
        public const string GetEnumeratorMethodName = "GetEnumerator";
        public const string GetObjectDataMethodName = "GetObjectData";
        public const string IdLocalName = "Id";
        public const string IntLocalName = "int";
        public const string IsAnyProperty = "IsAny";
        public const string IsDictionaryLocalName = "IsDictionary";
        public const string ISerializableFactoryTypeLocalName = "FactoryType";
        public const string IsRequiredProperty = "IsRequired";
        public const string IsValueTypeLocalName = "IsValueType";
        public const string ItemNameProperty = "ItemName";
        public const string KeyLocalName = "Key";
        public const string KeyNameProperty = "KeyName";
        public const string MoveNextMethodName = "MoveNext";
        public const string MscorlibAssemblyName = "0";
        public const string NameProperty = "Name";
        public const string NamespaceProperty = "Namespace";
        public const int NewObjectId = -1;
        public const string NodeArrayFieldName = "nodesField";
        public const string NodeArrayPropertyName = "Nodes";
        public const int NullObjectId = 0;
        public const string OccursUnbounded = "unbounded";
        public const string OrderProperty = "Order";
        public const string RefLocalName = "Ref";
        public const BindingFlags ScanAllMembers = (BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
        public const string SchemaInstanceNamespace = "http://www.w3.org/2001/XMLSchema-instance";
        public const string SchemaLocalName = "schema";
        public const string SchemaNamespace = "http://www.w3.org/2001/XMLSchema";
        public const string SerializationEntryFieldName = "entry";
        public const string SerializationInfoFieldName = "info";
        public const string SerializationInfoPropertyName = "SerializationInfo";
        public const string SerializationNamespace = "http://schemas.microsoft.com/2003/10/Serialization/";
        public const string SerializationSchema = "<?xml version='1.0' encoding='utf-8'?>\r\n<xs:schema elementFormDefault='qualified' attributeFormDefault='qualified' xmlns:tns='http://schemas.microsoft.com/2003/10/Serialization/' targetNamespace='http://schemas.microsoft.com/2003/10/Serialization/' xmlns:xs='http://www.w3.org/2001/XMLSchema'>\r\n  <xs:element name='anyType' nillable='true' type='xs:anyType' />\r\n  <xs:element name='anyURI' nillable='true' type='xs:anyURI' />\r\n  <xs:element name='base64Binary' nillable='true' type='xs:base64Binary' />\r\n  <xs:element name='boolean' nillable='true' type='xs:boolean' />\r\n  <xs:element name='byte' nillable='true' type='xs:byte' />\r\n  <xs:element name='dateTime' nillable='true' type='xs:dateTime' />\r\n  <xs:element name='decimal' nillable='true' type='xs:decimal' />\r\n  <xs:element name='double' nillable='true' type='xs:double' />\r\n  <xs:element name='float' nillable='true' type='xs:float' />\r\n  <xs:element name='int' nillable='true' type='xs:int' />\r\n  <xs:element name='long' nillable='true' type='xs:long' />\r\n  <xs:element name='QName' nillable='true' type='xs:QName' />\r\n  <xs:element name='short' nillable='true' type='xs:short' />\r\n  <xs:element name='string' nillable='true' type='xs:string' />\r\n  <xs:element name='unsignedByte' nillable='true' type='xs:unsignedByte' />\r\n  <xs:element name='unsignedInt' nillable='true' type='xs:unsignedInt' />\r\n  <xs:element name='unsignedLong' nillable='true' type='xs:unsignedLong' />\r\n  <xs:element name='unsignedShort' nillable='true' type='xs:unsignedShort' />\r\n  <xs:element name='char' nillable='true' type='tns:char' />\r\n  <xs:simpleType name='char'>\r\n    <xs:restriction base='xs:int'/>\r\n  </xs:simpleType>  \r\n  <xs:element name='duration' nillable='true' type='tns:duration' />\r\n  <xs:simpleType name='duration'>\r\n    <xs:restriction base='xs:duration'>\r\n      <xs:pattern value='\\-?P(\\d*D)?(T(\\d*H)?(\\d*M)?(\\d*(\\.\\d*)?S)?)?' />\r\n      <xs:minInclusive value='-P10675199DT2H48M5.4775808S' />\r\n      <xs:maxInclusive value='P10675199DT2H48M5.4775807S' />\r\n    </xs:restriction>\r\n  </xs:simpleType>\r\n  <xs:element name='guid' nillable='true' type='tns:guid' />\r\n  <xs:simpleType name='guid'>\r\n    <xs:restriction base='xs:string'>\r\n      <xs:pattern value='[\\da-fA-F]{8}-[\\da-fA-F]{4}-[\\da-fA-F]{4}-[\\da-fA-F]{4}-[\\da-fA-F]{12}' />\r\n    </xs:restriction>\r\n  </xs:simpleType>\r\n  <xs:attribute name='FactoryType' type='xs:QName' />\r\n</xs:schema>\r\n";
        public const string SerPrefix = "z";
        public const string SerPrefixForSchema = "ser";
        public const string Space = " ";
        public const string StringLocalName = "string";
        public const string SurrogateDataLocalName = "Surrogate";
        public const string TnsPrefix = "tns";
        public const string True = "true";
        private static Type typeOfArray;
        private static Type typeOfByteArray;
        private static Type typeOfDBNull;
        private static Type typeOfDictionaryGeneric;
        private static Type typeOfFlagsAttribute;
        private static Type typeOfGuid;
        private static Type typeOfHashtable;
        private static Type typeOfICollection;
        private static Type typeOfICollectionGeneric;
        private static Type typeOfIDeserializationCallback;
        private static Type typeOfIDictionary;
        private static Type typeOfIDictionaryEnumerator;
        private static Type typeOfIDictionaryGeneric;
        private static Type typeOfIEnumerable;
        private static Type typeOfIEnumerableGeneric;
        private static Type typeOfIEnumerator;
        private static Type typeOfIEnumeratorGeneric;
        private static Type typeOfIList;
        private static Type typeOfIListGeneric;
        private static Type typeOfInt;
        private static Type typeOfIObjectReference;
        private static Type typeOfIPropertyChange;
        private static Type typeOfISerializable;
        private static Type typeOfIXmlSerializable;
        private static Type typeOfKeyValuePair;
        private static Type typeOfListGeneric;
        private static Type typeOfNonSerializedAttribute;
        private static Type typeOfNullable;
        private static Type typeOfObject;
        private static Type typeOfObjectArray;
        private static Type typeOfOnDeserializedAttribute;
        private static Type typeOfOnDeserializingAttribute;
        private static Type typeOfOnSerializedAttribute;
        private static Type typeOfOnSerializingAttribute;
        private static Type typeOfOptionalFieldAttribute;
        private static Type typeOfReflectionPointer;
        private static Type typeOfSerializableAttribute;
        private static Type typeOfSerializationEntry;
        private static Type typeOfSerializationInfo;
        private static Type typeOfSerializationInfoEnumerator;
        private static Type typeOfStreamingContext;
        private static Type typeOfString;
        private static Type typeOfTimeSpan;
        private static Type typeOfTypeEnumerable;
        private static Type typeOfULong;
        private static Type typeOfUri;
        private static Type typeOfValueType;
        private static Type typeOfVoid;
        private static Type typeOfXmlElement;
        private static Type typeOfXmlNodeArray;
        private static Type typeOfXmlQualifiedName;
        private static Type typeOfXmlRootAttribute;
        private static Type typeOfXmlSchemaProviderAttribute;
        private static Type typeOfXmlSchemaSet;
        private static Type typeOfXmlSchemaType;
        public const string ValueLocalName = "Value";
        public const string ValueNameProperty = "ValueName";
        public const string ValueProperty = "Value";
        public const string XmlnsNamespace = "http://www.w3.org/2000/xmlns/";
        public const string XmlnsPrefix = "xmlns";
        public const string XsdPrefix = "x";
        public const string XsiNilLocalName = "nil";
        public const string XsiPrefix = "i";
        public const string XsiTypeLocalName = "type";

        // Properties
        public static Uri DataContractXsdBaseNamespaceUri
        {
            get
            {
                if (dataContractXsdBaseNamespaceUri == null)
                {
                    dataContractXsdBaseNamespaceUri = new Uri("http://schemas.datacontract.org/2004/07/");
                }
                return dataContractXsdBaseNamespaceUri;
            }
        }

        public static object[] EmptyObjectArray
        {
            get
            {
                if (emptyObjectArray == null)
                {
                    emptyObjectArray = new object[0];
                }
                return emptyObjectArray;
            }
        }

        public static Type[] EmptyTypeArray
        {
            get
            {
                if (emptyTypeArray == null)
                {
                    emptyTypeArray = new Type[0];
                }
                return emptyTypeArray;
            }
        }

        public static Type TypeOfArray
        {
            get
            {
                if (typeOfArray == null)
                {
                    typeOfArray = typeof(Array);
                }
                return typeOfArray;
            }
        }

        public static Type TypeOfByteArray
        {
            get
            {
                if (typeOfByteArray == null)
                {
                    typeOfByteArray = typeof(byte[]);
                }
                return typeOfByteArray;
            }
        }

        public static Type TypeOfDBNull
        {
            get
            {
                if (typeOfDBNull == null)
                {
                    typeOfDBNull = typeof(DBNull);
                }
                return typeOfDBNull;
            }
        }

        public static Type TypeOfDictionaryGeneric
        {
            get
            {
                if (typeOfDictionaryGeneric == null)
                {
                    typeOfDictionaryGeneric = typeof(Dictionary<,>);
                }
                return typeOfDictionaryGeneric;
            }
        }

        public static Type TypeOfFlagsAttribute
        {
            get
            {
                if (typeOfFlagsAttribute == null)
                {
                    typeOfFlagsAttribute = typeof(FlagsAttribute);
                }
                return typeOfFlagsAttribute;
            }
        }

        public static Type TypeOfGuid
        {
            get
            {
                if (typeOfGuid == null)
                {
                    typeOfGuid = typeof(Guid);
                }
                return typeOfGuid;
            }
        }

        public static Type TypeOfHashtable
        {
            get
            {
                if (typeOfHashtable == null)
                {
                    typeOfHashtable = typeof(Hashtable);
                }
                return typeOfHashtable;
            }
        }

        public static Type TypeOfICollection
        {
            get
            {
                if (typeOfICollection == null)
                {
                    typeOfICollection = typeof(ICollection);
                }
                return typeOfICollection;
            }
        }

        public static Type TypeOfICollectionGeneric
        {
            get
            {
                if (typeOfICollectionGeneric == null)
                {
                    typeOfICollectionGeneric = typeof(ICollection<>);
                }
                return typeOfICollectionGeneric;
            }
        }

        public static Type TypeOfIDeserializationCallback
        {
            get
            {
                if (typeOfIDeserializationCallback == null)
                {
                    typeOfIDeserializationCallback = typeof(IDeserializationCallback);
                }
                return typeOfIDeserializationCallback;
            }
        }

        public static Type TypeOfIDictionary
        {
            get
            {
                if (typeOfIDictionary == null)
                {
                    typeOfIDictionary = typeof(IDictionary);
                }
                return typeOfIDictionary;
            }
        }

        public static Type TypeOfIDictionaryEnumerator
        {
            get
            {
                if (typeOfIDictionaryEnumerator == null)
                {
                    typeOfIDictionaryEnumerator = typeof(IDictionaryEnumerator);
                }
                return typeOfIDictionaryEnumerator;
            }
        }

        public static Type TypeOfIDictionaryGeneric
        {
            get
            {
                if (typeOfIDictionaryGeneric == null)
                {
                    typeOfIDictionaryGeneric = typeof(IDictionary<,>);
                }
                return typeOfIDictionaryGeneric;
            }
        }

        public static Type TypeOfIEnumerable
        {
            get
            {
                if (typeOfIEnumerable == null)
                {
                    typeOfIEnumerable = typeof(IEnumerable);
                }
                return typeOfIEnumerable;
            }
        }

        public static Type TypeOfIEnumerableGeneric
        {
            get
            {
                if (typeOfIEnumerableGeneric == null)
                {
                    typeOfIEnumerableGeneric = typeof(IEnumerable<>);
                }
                return typeOfIEnumerableGeneric;
            }
        }

        public static Type TypeOfIEnumerator
        {
            get
            {
                if (typeOfIEnumerator == null)
                {
                    typeOfIEnumerator = typeof(IEnumerator);
                }
                return typeOfIEnumerator;
            }
        }

        public static Type TypeOfIEnumeratorGeneric
        {
            get
            {
                if (typeOfIEnumeratorGeneric == null)
                {
                    typeOfIEnumeratorGeneric = typeof(IEnumerator<>);
                }
                return typeOfIEnumeratorGeneric;
            }
        }

        public static Type TypeOfIList
        {
            get
            {
                if (typeOfIList == null)
                {
                    typeOfIList = typeof(IList);
                }
                return typeOfIList;
            }
        }

        public static Type TypeOfIListGeneric
        {
            get
            {
                if (typeOfIListGeneric == null)
                {
                    typeOfIListGeneric = typeof(IList<>);
                }
                return typeOfIListGeneric;
            }
        }

        public static Type TypeOfInt
        {
            get
            {
                if (typeOfInt == null)
                {
                    typeOfInt = typeof(int);
                }
                return typeOfInt;
            }
        }

        public static Type TypeOfIObjectReference
        {
            get
            {
                if (typeOfIObjectReference == null)
                {
                    typeOfIObjectReference = typeof(IObjectReference);
                }
                return typeOfIObjectReference;
            }
        }

        public static Type TypeOfIPropertyChange
        {
            get
            {
                if (typeOfIPropertyChange == null)
                {
                    typeOfIPropertyChange = typeof(INotifyPropertyChanged);
                }
                return typeOfIPropertyChange;
            }
        }

        public static Type TypeOfISerializable
        {
            get
            {
                if (typeOfISerializable == null)
                {
                    typeOfISerializable = typeof(ISerializable);
                }
                return typeOfISerializable;
            }
        }

        public static Type TypeOfIXmlSerializable
        {
            get
            {
                if (typeOfIXmlSerializable == null)
                {
                    typeOfIXmlSerializable = typeof(IXmlSerializable);
                }
                return typeOfIXmlSerializable;
            }
        }

        public static Type TypeOfKeyValuePair
        {
            get
            {
                if (typeOfKeyValuePair == null)
                {
                    typeOfKeyValuePair = typeof(KeyValuePair<,>);
                }
                return typeOfKeyValuePair;
            }
        }

        public static Type TypeOfListGeneric
        {
            get
            {
                if (typeOfListGeneric == null)
                {
                    typeOfListGeneric = typeof(List<>);
                }
                return typeOfListGeneric;
            }
        }

        public static Type TypeOfNonSerializedAttribute
        {
            get
            {
                if (typeOfNonSerializedAttribute == null)
                {
                    typeOfNonSerializedAttribute = typeof(NonSerializedAttribute);
                }
                return typeOfNonSerializedAttribute;
            }
        }

        public static Type TypeOfNullable
        {
            get
            {
                if (typeOfNullable == null)
                {
                    typeOfNullable = typeof(Nullable<>);
                }
                return typeOfNullable;
            }
        }

        public static Type TypeOfObject
        {
            get
            {
                if (typeOfObject == null)
                {
                    typeOfObject = typeof(object);
                }
                return typeOfObject;
            }
        }

        public static Type TypeOfObjectArray
        {
            get
            {
                if (typeOfObjectArray == null)
                {
                    typeOfObjectArray = typeof(object[]);
                }
                return typeOfObjectArray;
            }
        }

        public static Type TypeOfOnDeserializedAttribute
        {
            get
            {
                if (typeOfOnDeserializedAttribute == null)
                {
                    typeOfOnDeserializedAttribute = typeof(OnDeserializedAttribute);
                }
                return typeOfOnDeserializedAttribute;
            }
        }

        public static Type TypeOfOnDeserializingAttribute
        {
            get
            {
                if (typeOfOnDeserializingAttribute == null)
                {
                    typeOfOnDeserializingAttribute = typeof(OnDeserializingAttribute);
                }
                return typeOfOnDeserializingAttribute;
            }
        }

        public static Type TypeOfOnSerializedAttribute
        {
            get
            {
                if (typeOfOnSerializedAttribute == null)
                {
                    typeOfOnSerializedAttribute = typeof(OnSerializedAttribute);
                }
                return typeOfOnSerializedAttribute;
            }
        }

        public static Type TypeOfOnSerializingAttribute
        {
            get
            {
                if (typeOfOnSerializingAttribute == null)
                {
                    typeOfOnSerializingAttribute = typeof(OnSerializingAttribute);
                }
                return typeOfOnSerializingAttribute;
            }
        }

        public static Type TypeOfOptionalFieldAttribute
        {
            get
            {
                if (typeOfOptionalFieldAttribute == null)
                {
                    typeOfOptionalFieldAttribute = typeof(OptionalFieldAttribute);
                }
                return typeOfOptionalFieldAttribute;
            }
        }

        public static Type TypeOfReflectionPointer
        {
            get
            {
                if (typeOfReflectionPointer == null)
                {
                    typeOfReflectionPointer = typeof(Pointer);
                }
                return typeOfReflectionPointer;
            }
        }

        public static Type TypeOfSerializableAttribute
        {
            get
            {
                if (typeOfSerializableAttribute == null)
                {
                    typeOfSerializableAttribute = typeof(SerializableAttribute);
                }
                return typeOfSerializableAttribute;
            }
        }

        public static Type TypeOfSerializationEntry
        {
            get
            {
                if (typeOfSerializationEntry == null)
                {
                    typeOfSerializationEntry = typeof(SerializationEntry);
                }
                return typeOfSerializationEntry;
            }
        }

        public static Type TypeOfSerializationInfo
        {
            get
            {
                if (typeOfSerializationInfo == null)
                {
                    typeOfSerializationInfo = typeof(SerializationInfo);
                }
                return typeOfSerializationInfo;
            }
        }

        public static Type TypeOfSerializationInfoEnumerator
        {
            get
            {
                if (typeOfSerializationInfoEnumerator == null)
                {
                    typeOfSerializationInfoEnumerator = typeof(SerializationInfoEnumerator);
                }
                return typeOfSerializationInfoEnumerator;
            }
        }

        public static Type TypeOfStreamingContext
        {
            get
            {
                if (typeOfStreamingContext == null)
                {
                    typeOfStreamingContext = typeof(StreamingContext);
                }
                return typeOfStreamingContext;
            }
        }

        public static Type TypeOfString
        {
            get
            {
                if (typeOfString == null)
                {
                    typeOfString = typeof(string);
                }
                return typeOfString;
            }
        }

        public static Type TypeOfTimeSpan
        {
            get
            {
                if (typeOfTimeSpan == null)
                {
                    typeOfTimeSpan = typeof(TimeSpan);
                }
                return typeOfTimeSpan;
            }
        }

        public static Type TypeOfTypeEnumerable
        {
            get
            {
                if (typeOfTypeEnumerable == null)
                {
                    typeOfTypeEnumerable = typeof(IEnumerable<Type>);
                }
                return typeOfTypeEnumerable;
            }
        }

        public static Type TypeOfULong
        {
            get
            {
                if (typeOfULong == null)
                {
                    typeOfULong = typeof(ulong);
                }
                return typeOfULong;
            }
        }

        public static Type TypeOfUri
        {
            get
            {
                if (typeOfUri == null)
                {
                    typeOfUri = typeof(Uri);
                }
                return typeOfUri;
            }
        }

        public static Type TypeOfValueType
        {
            get
            {
                if (typeOfValueType == null)
                {
                    typeOfValueType = typeof(ValueType);
                }
                return typeOfValueType;
            }
        }

        public static Type TypeOfVoid
        {
            get
            {
                if (typeOfVoid == null)
                {
                    typeOfVoid = typeof(void);
                }
                return typeOfVoid;
            }
        }

        public static Type TypeOfXmlElement
        {
            get
            {
                if (typeOfXmlElement == null)
                {
                    typeOfXmlElement = typeof(XmlElement);
                }
                return typeOfXmlElement;
            }
        }

        public static Type TypeOfXmlNodeArray
        {
            get
            {
                if (typeOfXmlNodeArray == null)
                {
                    typeOfXmlNodeArray = typeof(XmlNode[]);
                }
                return typeOfXmlNodeArray;
            }
        }

        public static Type TypeOfXmlQualifiedName
        {
            get
            {
                if (typeOfXmlQualifiedName == null)
                {
                    typeOfXmlQualifiedName = typeof(XmlQualifiedName);
                }
                return typeOfXmlQualifiedName;
            }
        }

        public static Type TypeOfXmlRootAttribute
        {
            get
            {
                if (typeOfXmlRootAttribute == null)
                {
                    typeOfXmlRootAttribute = typeof(XmlRootAttribute);
                }
                return typeOfXmlRootAttribute;
            }
        }

        public static Type TypeOfXmlSchemaProviderAttribute
        {
            get
            {
                if (typeOfXmlSchemaProviderAttribute == null)
                {
                    typeOfXmlSchemaProviderAttribute = typeof(XmlSchemaProviderAttribute);
                }
                return typeOfXmlSchemaProviderAttribute;
            }
        }

        public static Type TypeOfXmlSchemaSet
        {
            get
            {
                if (typeOfXmlSchemaSet == null)
                {
                    typeOfXmlSchemaSet = typeof(XmlSchemaSet);
                }
                return typeOfXmlSchemaSet;
            }
        }

        public static Type TypeOfXmlSchemaType
        {
            get
            {
                if (typeOfXmlSchemaType == null)
                {
                    typeOfXmlSchemaType = typeof(XmlSchemaType);
                }
                return typeOfXmlSchemaType;
            }
        }
    }

    public class ForState
    {
        // Fields
        private Label beginLabel;
        private object end;
        private Label endLabel;
        private LocalBuilder indexVar;
        private bool requiresEndLabel;
        private Label testLabel;

        // Methods
        public ForState(LocalBuilder indexVar, Label beginLabel, Label testLabel, object end)
        {
            this.indexVar = indexVar;
            this.beginLabel = beginLabel;
            this.testLabel = testLabel;
            this.end = end;
        }

        // Properties
        public Label BeginLabel
        {
            get
            {
                return this.beginLabel;
            }
        }

        public object End
        {
            get
            {
                return this.end;
            }
        }

        public Label EndLabel
        {
            get
            {
                return this.endLabel;
            }
            set
            {
                this.endLabel = value;
            }
        }

        public LocalBuilder Index
        {
            get
            {
                return this.indexVar;
            }
        }

        public bool RequiresEndLabel
        {
            get
            {
                return this.requiresEndLabel;
            }
            set
            {
                this.requiresEndLabel = value;
            }
        }

        public Label TestLabel
        {
            get
            {
                return this.testLabel;
            }
        }
    }

    public class CodeGenerator
    {
        // Fields
        private ArrayList argList;
        private Stack blockStack;
        private Type delegateType;
        private DynamicMethod dynamicMethod;
        private static MethodInfo getTypeFromHandle;
        private ILGenerator ilGen;
        private Hashtable localNames;
        private Label methodEndLabel;
        private static MethodInfo objectEquals;
        private static MethodInfo objectToString;
        private Module serializationModule = typeof(CodeGenerator).Module;
        private static MethodInfo stringConcat2;
        private static MethodInfo stringConcat3;
        private static MethodInfo stringFormat;
        private LocalBuilder stringFormatArray;

        // Methods
        public CodeGenerator()
        {
        }

        public CodeGenerator(Module targetModule) : this()
        {
            Check.Require(targetModule != null, "targetModule could not be null.");

            this.serializationModule = targetModule;
        }

        public void Add()
        {
            this.ilGen.Emit(OpCodes.Add);
        }

        public void And()
        {
            this.ilGen.Emit(OpCodes.And);
        }

        public void BeginMethod(string methodName, Type delegateType)
        {
            MethodInfo method = delegateType.GetMethod("Invoke");
            ParameterInfo[] parameters = method.GetParameters();
            Type[] argTypes = new Type[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                argTypes[i] = parameters[i].ParameterType;
            }
            this.BeginMethod(method.ReturnType, methodName, argTypes);
            this.delegateType = delegateType;
        }

        private void BeginMethod(Type returnType, string methodName, params Type[] argTypes)
        {
            this.dynamicMethod = new DynamicMethod(methodName, returnType, argTypes, serializationModule, true);
            this.ilGen = this.dynamicMethod.GetILGenerator();
            this.methodEndLabel = this.ilGen.DefineLabel();
            this.blockStack = new Stack();
            this.argList = new ArrayList();
            for (int i = 0; i < argTypes.Length; i++)
            {
                this.argList.Add(new ArgBuilder(i, argTypes[i]));
            }
        }

        public void Bgt(Label label)
        {
            this.ilGen.Emit(OpCodes.Bgt, label);
        }

        public void Ble(Label label)
        {
            this.ilGen.Emit(OpCodes.Ble, label);
        }

        public void Blt(Label label)
        {
            this.ilGen.Emit(OpCodes.Blt, label);
        }

        public void Box(Type type)
        {
            this.ilGen.Emit(OpCodes.Box, type);
        }

        public void Br(Label label)
        {
            this.ilGen.Emit(OpCodes.Br, label);
        }

        public void Break(object forState)
        {
            this.InternalBreakFor(forState, OpCodes.Br);
        }

        public void Brfalse(Label label)
        {
            this.ilGen.Emit(OpCodes.Brfalse, label);
        }

        public void Brtrue(Label label)
        {
            this.ilGen.Emit(OpCodes.Brtrue, label);
        }

        public void Call(ConstructorInfo ctor)
        {
            this.ilGen.Emit(OpCodes.Call, ctor);
        }

        public void Call(MethodInfo methodInfo)
        {
            if (methodInfo.IsVirtual)
            {
                this.ilGen.Emit(OpCodes.Callvirt, methodInfo);
            }
            else if (methodInfo.IsStatic)
            {
                this.ilGen.Emit(OpCodes.Call, methodInfo);
            }
            else
            {
                this.ilGen.Emit(OpCodes.Call, methodInfo);
            }
        }

        public void Call(object thisObj, MethodInfo methodInfo)
        {
            this.VerifyParameterCount(methodInfo, 0);
            this.LoadThis(thisObj, methodInfo);
            this.Call(methodInfo);
        }

        public void Call(object thisObj, MethodInfo methodInfo, object param1)
        {
            this.VerifyParameterCount(methodInfo, 1);
            this.LoadThis(thisObj, methodInfo);
            this.LoadParam(param1, 1, methodInfo);
            this.Call(methodInfo);
        }

        public void Call(object thisObj, MethodInfo methodInfo, object param1, object param2)
        {
            this.VerifyParameterCount(methodInfo, 2);
            this.LoadThis(thisObj, methodInfo);
            this.LoadParam(param1, 1, methodInfo);
            this.LoadParam(param2, 2, methodInfo);
            this.Call(methodInfo);
        }

        public void Call(object thisObj, MethodInfo methodInfo, object param1, object param2, object param3)
        {
            this.VerifyParameterCount(methodInfo, 3);
            this.LoadThis(thisObj, methodInfo);
            this.LoadParam(param1, 1, methodInfo);
            this.LoadParam(param2, 2, methodInfo);
            this.LoadParam(param3, 3, methodInfo);
            this.Call(methodInfo);
        }

        public void Call(object thisObj, MethodInfo methodInfo, object param1, object param2, object param3, object param4)
        {
            this.VerifyParameterCount(methodInfo, 4);
            this.LoadThis(thisObj, methodInfo);
            this.LoadParam(param1, 1, methodInfo);
            this.LoadParam(param2, 2, methodInfo);
            this.LoadParam(param3, 3, methodInfo);
            this.LoadParam(param4, 4, methodInfo);
            this.Call(methodInfo);
        }

        public void Call(object thisObj, MethodInfo methodInfo, object param1, object param2, object param3, object param4, object param5)
        {
            this.VerifyParameterCount(methodInfo, 5);
            this.LoadThis(thisObj, methodInfo);
            this.LoadParam(param1, 1, methodInfo);
            this.LoadParam(param2, 2, methodInfo);
            this.LoadParam(param3, 3, methodInfo);
            this.LoadParam(param4, 4, methodInfo);
            this.LoadParam(param5, 5, methodInfo);
            this.Call(methodInfo);
        }

        public void Call(object thisObj, MethodInfo methodInfo, object param1, object param2, object param3, object param4, object param5, object param6)
        {
            this.VerifyParameterCount(methodInfo, 6);
            this.LoadThis(thisObj, methodInfo);
            this.LoadParam(param1, 1, methodInfo);
            this.LoadParam(param2, 2, methodInfo);
            this.LoadParam(param3, 3, methodInfo);
            this.LoadParam(param4, 4, methodInfo);
            this.LoadParam(param5, 5, methodInfo);
            this.LoadParam(param6, 6, methodInfo);
            this.Call(methodInfo);
        }

        public void CallStringFormat(string msg, params object[] values)
        {
            this.NewArray(typeof(object), values.Length);
            if (this.stringFormatArray == null)
            {
                this.stringFormatArray = this.DeclareLocal(typeof(object[]), "stringFormatArray");
            }
            this.Stloc(this.stringFormatArray);
            for (int i = 0; i < values.Length; i++)
            {
                this.StoreArrayElement(this.stringFormatArray, i, values[i]);
            }
            this.Load(msg);
            this.Load(this.stringFormatArray);
            this.Call(StringFormat);
        }

        public void Case(Label caseLabel1, string caseLabelName)
        {
            this.MarkLabel(caseLabel1);
        }

        public void Castclass(Type target)
        {
            this.ilGen.Emit(OpCodes.Castclass, target);
        }

        public void Ceq()
        {
            this.ilGen.Emit(OpCodes.Ceq);
        }

        public void Concat2()
        {
            this.Call(StringConcat2);
        }

        public void Concat3()
        {
            this.Call(StringConcat3);
        }

        public void ConvertAddress(Type source, Type target)
        {
            this.InternalConvert(source, target, true);
        }

        public void ConvertValue(Type source, Type target)
        {
            this.InternalConvert(source, target, false);
        }

        public void Dec(object var)
        {
            this.Load(var);
            this.Load(1);
            this.Subtract();
            this.Store(var);
        }

        public LocalBuilder DeclareLocal(Type type, string name)
        {
            return this.DeclareLocal(type, name, false);
        }

        public LocalBuilder DeclareLocal(Type type, string name, bool isPinned)
        {
            LocalBuilder builder = this.ilGen.DeclareLocal(type, isPinned);
            return builder;
        }

        public LocalBuilder DeclareLocal(Type type, string name, object initialValue)
        {
            LocalBuilder var = this.DeclareLocal(type, name);
            this.Load(initialValue);
            this.Store(var);
            return var;
        }

        public void DefaultCase()
        {
            object expected = this.blockStack.Peek();
            SwitchState state = expected as SwitchState;
            if (state == null)
            {
                this.ThrowMismatchException(expected);
            }
            this.MarkLabel(state.DefaultLabel);
            state.DefaultDefined = true;
        }

        public Label DefineLabel()
        {
            return this.ilGen.DefineLabel();
        }

        public void Dup()
        {
            this.ilGen.Emit(OpCodes.Dup);
        }

        public void Else()
        {
            IfState state = this.PopIfState();
            this.Br(state.EndIf);
            this.MarkLabel(state.ElseBegin);
            state.ElseBegin = state.EndIf;
            this.blockStack.Push(state);
        }

        public void ElseIf(object value1, Cmp cmpOp, object value2)
        {
            IfState state = (IfState) this.blockStack.Pop();
            this.Br(state.EndIf);
            this.MarkLabel(state.ElseBegin);
            this.Load(value1);
            this.Load(value2);
            state.ElseBegin = this.DefineLabel();
            this.ilGen.Emit(this.GetBranchCode(cmpOp), state.ElseBegin);
            this.blockStack.Push(state);
        }

        public void EndCase()
        {
            object expected = this.blockStack.Peek();
            SwitchState state = expected as SwitchState;
            if (state == null)
            {
                this.ThrowMismatchException(expected);
            }
            this.Br(state.EndOfSwitchLabel);
        }

        public void EndFor()
        {
            object expected = this.blockStack.Pop();
            ForState state = expected as ForState;
            if (state == null)
            {
                this.ThrowMismatchException(expected);
            }
            if (state.Index != null)
            {
                this.Ldloc(state.Index);
                this.Ldc(1);
                this.Add();
                this.Stloc(state.Index);
                this.MarkLabel(state.TestLabel);
                this.Ldloc(state.Index);
                this.Load(state.End);
                if (this.GetVariableType(state.End).IsArray)
                {
                    this.Ldlen();
                }
                this.Blt(state.BeginLabel);
            }
            else
            {
                this.Br(state.BeginLabel);
            }
            if (state.RequiresEndLabel)
            {
                this.MarkLabel(state.EndLabel);
            }
        }

        public void EndForEach(MethodInfo moveNextMethod)
        {
            object expected = this.blockStack.Pop();
            ForState state = expected as ForState;
            if (state == null)
            {
                this.ThrowMismatchException(expected);
            }
            this.MarkLabel(state.TestLabel);
            object var = state.End;
            if (this.GetVariableType(var) == moveNextMethod.DeclaringType)
            {
                this.LoadThis(var, moveNextMethod);
                this.ilGen.Emit(OpCodes.Call, moveNextMethod);
            }
            else
            {
                this.Call(var, moveNextMethod);
            }
            this.Brtrue(state.BeginLabel);
            if (state.RequiresEndLabel)
            {
                this.MarkLabel(state.EndLabel);
            }
        }

        public void EndIf()
        {
            IfState state = this.PopIfState();
            if (!state.ElseBegin.Equals(state.EndIf))
            {
                this.MarkLabel(state.ElseBegin);
            }
            this.MarkLabel(state.EndIf);
        }

        public Delegate EndMethod()
        {
            this.MarkLabel(this.methodEndLabel);
            this.Ret();
            Delegate delegate2 = null;
            delegate2 = this.dynamicMethod.CreateDelegate(this.delegateType);
            this.dynamicMethod = null;
            this.delegateType = null;
            this.ilGen = null;
            this.blockStack = null;
            this.argList = null;
            return delegate2;
        }

        public void EndSwitch()
        {
            object expected = this.blockStack.Pop();
            SwitchState state = expected as SwitchState;
            if (state == null)
            {
                this.ThrowMismatchException(expected);
            }
            if (!state.DefaultDefined)
            {
                this.MarkLabel(state.DefaultLabel);
            }
            this.MarkLabel(state.EndOfSwitchLabel);
        }

        public object For(LocalBuilder local, object start, object end)
        {
            ForState state = new ForState(local, this.DefineLabel(), this.DefineLabel(), end);
            if (state.Index != null)
            {
                this.Load(start);
                this.Stloc(state.Index);
                this.Br(state.TestLabel);
            }
            this.MarkLabel(state.BeginLabel);
            this.blockStack.Push(state);
            return state;
        }

        public void ForEach(LocalBuilder local, Type elementType, Type enumeratorType, LocalBuilder enumerator, MethodInfo getCurrentMethod)
        {
            ForState state = new ForState(local, this.DefineLabel(), this.DefineLabel(), enumerator);
            this.Br(state.TestLabel);
            this.MarkLabel(state.BeginLabel);
            if (enumeratorType == getCurrentMethod.DeclaringType)
            {
                this.LoadThis(enumerator, getCurrentMethod);
                this.ilGen.Emit(OpCodes.Call, getCurrentMethod);
            }
            else
            {
                this.Call(enumerator, getCurrentMethod);
            }
            this.ConvertValue(elementType, this.GetVariableType(local));
            this.Stloc(local);
            this.blockStack.Push(state);
        }

        public ArgBuilder GetArg(int index)
        {
            return (ArgBuilder) this.argList[index];
        }

        private OpCode GetBranchCode(Cmp cmp)
        {
            switch (cmp)
            {
                case Cmp.LessThan:
                    return OpCodes.Bge;

                case Cmp.EqualTo:
                    return OpCodes.Bne_Un;

                case Cmp.LessThanOrEqualTo:
                    return OpCodes.Bgt;

                case Cmp.GreaterThan:
                    return OpCodes.Ble;

                case Cmp.NotEqualTo:
                    return OpCodes.Beq;
            }
            return OpCodes.Blt;
        }

        private Cmp GetCmpInverse(Cmp cmp)
        {
            switch (cmp)
            {
                case Cmp.LessThan:
                    return Cmp.GreaterThanOrEqualTo;

                case Cmp.EqualTo:
                    return Cmp.NotEqualTo;

                case Cmp.LessThanOrEqualTo:
                    return Cmp.GreaterThan;

                case Cmp.GreaterThan:
                    return Cmp.LessThanOrEqualTo;

                case Cmp.NotEqualTo:
                    return Cmp.EqualTo;
            }
            return Cmp.LessThan;
        }

        private OpCode GetConvOpCode(TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Boolean:
                    return OpCodes.Conv_I1;

                case TypeCode.Char:
                    return OpCodes.Conv_I2;

                case TypeCode.SByte:
                    return OpCodes.Conv_I1;

                case TypeCode.Byte:
                    return OpCodes.Conv_U1;

                case TypeCode.Int16:
                    return OpCodes.Conv_I2;

                case TypeCode.UInt16:
                    return OpCodes.Conv_U2;

                case TypeCode.Int32:
                    return OpCodes.Conv_I4;

                case TypeCode.UInt32:
                    return OpCodes.Conv_U4;

                case TypeCode.Int64:
                    return OpCodes.Conv_I8;

                case TypeCode.UInt64:
                    return OpCodes.Conv_I8;

                case TypeCode.Single:
                    return OpCodes.Conv_R4;

                case TypeCode.Double:
                    return OpCodes.Conv_R8;
            }
            return OpCodes.Nop;
        }

        private OpCode GetLdelemOpCode(TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Object:
                case TypeCode.DBNull:
                    return OpCodes.Ldelem_Ref;

                case TypeCode.Boolean:
                    return OpCodes.Ldelem_I1;

                case TypeCode.Char:
                    return OpCodes.Ldelem_I2;

                case TypeCode.SByte:
                    return OpCodes.Ldelem_I1;

                case TypeCode.Byte:
                    return OpCodes.Ldelem_U1;

                case TypeCode.Int16:
                    return OpCodes.Ldelem_I2;

                case TypeCode.UInt16:
                    return OpCodes.Ldelem_U2;

                case TypeCode.Int32:
                    return OpCodes.Ldelem_I4;

                case TypeCode.UInt32:
                    return OpCodes.Ldelem_U4;

                case TypeCode.Int64:
                    return OpCodes.Ldelem_I8;

                case TypeCode.UInt64:
                    return OpCodes.Ldelem_I8;

                case TypeCode.Single:
                    return OpCodes.Ldelem_R4;

                case TypeCode.Double:
                    return OpCodes.Ldelem_R8;

                case TypeCode.String:
                    return OpCodes.Ldelem_Ref;
            }
            return OpCodes.Nop;
        }

        private OpCode GetLdindOpCode(TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Boolean:
                    return OpCodes.Ldind_I1;

                case TypeCode.Char:
                    return OpCodes.Ldind_I2;

                case TypeCode.SByte:
                    return OpCodes.Ldind_I1;

                case TypeCode.Byte:
                    return OpCodes.Ldind_U1;

                case TypeCode.Int16:
                    return OpCodes.Ldind_I2;

                case TypeCode.UInt16:
                    return OpCodes.Ldind_U2;

                case TypeCode.Int32:
                    return OpCodes.Ldind_I4;

                case TypeCode.UInt32:
                    return OpCodes.Ldind_U4;

                case TypeCode.Int64:
                    return OpCodes.Ldind_I8;

                case TypeCode.UInt64:
                    return OpCodes.Ldind_I8;

                case TypeCode.Single:
                    return OpCodes.Ldind_R4;

                case TypeCode.Double:
                    return OpCodes.Ldind_R8;

                case TypeCode.String:
                    return OpCodes.Ldind_Ref;
            }
            return OpCodes.Nop;
        }

        private OpCode GetStelemOpCode(TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Object:
                case TypeCode.DBNull:
                    return OpCodes.Stelem_Ref;

                case TypeCode.Boolean:
                    return OpCodes.Stelem_I1;

                case TypeCode.Char:
                    return OpCodes.Stelem_I2;

                case TypeCode.SByte:
                    return OpCodes.Stelem_I1;

                case TypeCode.Byte:
                    return OpCodes.Stelem_I1;

                case TypeCode.Int16:
                    return OpCodes.Stelem_I2;

                case TypeCode.UInt16:
                    return OpCodes.Stelem_I2;

                case TypeCode.Int32:
                    return OpCodes.Stelem_I4;

                case TypeCode.UInt32:
                    return OpCodes.Stelem_I4;

                case TypeCode.Int64:
                    return OpCodes.Stelem_I8;

                case TypeCode.UInt64:
                    return OpCodes.Stelem_I8;

                case TypeCode.Single:
                    return OpCodes.Stelem_R4;

                case TypeCode.Double:
                    return OpCodes.Stelem_R8;

                case TypeCode.String:
                    return OpCodes.Stelem_Ref;
            }
            return OpCodes.Nop;
        }

        public Type GetVariableType(object var)
        {
            if (var is ArgBuilder)
            {
                return ((ArgBuilder) var).ArgType;
            }
            if (var is LocalBuilder)
            {
                return ((LocalBuilder) var).LocalType;
            }
            return var.GetType();
        }

        public void If()
        {
            this.InternalIf(false);
        }

        public void If(Cmp cmpOp)
        {
            IfState state = new IfState();
            state.EndIf = this.DefineLabel();
            state.ElseBegin = this.DefineLabel();
            this.ilGen.Emit(this.GetBranchCode(cmpOp), state.ElseBegin);
            this.blockStack.Push(state);
        }

        public void If(object value1, Cmp cmpOp, object value2)
        {
            this.Load(value1);
            this.Load(value2);
            this.If(cmpOp);
        }

        public void IfFalseBreak(object forState)
        {
            this.InternalBreakFor(forState, OpCodes.Brfalse);
        }

        public void IfNot()
        {
            this.InternalIf(true);
        }

        public void IfNotDefaultValue(object value)
        {
            Type variableType = this.GetVariableType(value);
            TypeCode typeCode = Type.GetTypeCode(variableType);
            if (((typeCode == TypeCode.Object) && variableType.IsValueType) || ((typeCode == TypeCode.DateTime) || (typeCode == TypeCode.Decimal)))
            {
                this.LoadDefaultValue(variableType);
                this.ConvertValue(variableType, Globals.TypeOfObject);
                this.Load(value);
                this.ConvertValue(variableType, Globals.TypeOfObject);
                this.Call(ObjectEquals);
                this.IfNot();
            }
            else
            {
                this.LoadDefaultValue(variableType);
                this.Load(value);
                this.If(Cmp.NotEqualTo);
            }
        }

        public void IfTrueBreak(object forState)
        {
            this.InternalBreakFor(forState, OpCodes.Brtrue);
        }

        public void IgnoreReturnValue()
        {
            this.Pop();
        }

        public void Inc(object var)
        {
            this.Load(var);
            this.Load(1);
            this.Add();
            this.Store(var);
        }

        public void InitObj(Type valueType)
        {
            this.ilGen.Emit(OpCodes.Initobj, valueType);
        }

        public void InternalBreakFor(object userForState, OpCode branchInstruction)
        {
            foreach (object obj2 in this.blockStack)
            {
                ForState state = obj2 as ForState;
                if ((state != null) && (state == userForState))
                {
                    if (!state.RequiresEndLabel)
                    {
                        state.EndLabel = this.DefineLabel();
                        state.RequiresEndLabel = true;
                    }
                    this.ilGen.Emit(branchInstruction, state.EndLabel);
                    break;
                }
            }
        }

        private void InternalConvert(Type source, Type target, bool isAddress)
        {
            if (target != source)
            {
                if (target.IsValueType)
                {
                    if (source.IsValueType)
                    {
                        OpCode opcode = this.GetConvOpCode(Type.GetTypeCode(target));
                        if (opcode.Equals(OpCodes.Nop))
                        {
                            throw new Exception("NoConversionPossible");
                        }
                        this.ilGen.Emit(opcode);
                    }
                    else
                    {
                        if (!source.IsAssignableFrom(target))
                        {
                            throw new Exception("IsNotAssignableFrom");
                        }
                        this.Unbox(target);
                        if (!isAddress)
                        {
                            this.Ldobj(target);
                        }
                    }
                }
                else if (target.IsAssignableFrom(source))
                {
                    if (source.IsValueType)
                    {
                        if (isAddress)
                        {
                            this.Ldobj(source);
                        }
                        this.Box(source);
                    }
                }
                else if (source.IsAssignableFrom(target))
                {
                    this.Castclass(target);
                }
                else
                {
                    if (!target.IsInterface && !source.IsInterface)
                    {
                        throw new Exception("IsNotAssignableFrom");
                    }
                    this.Castclass(target);
                }
            }
        }

        private void InternalIf(bool negate)
        {
            IfState state = new IfState();
            state.EndIf = this.DefineLabel();
            state.ElseBegin = this.DefineLabel();
            if (negate)
            {
                this.Brtrue(state.ElseBegin);
            }
            else
            {
                this.Brfalse(state.ElseBegin);
            }
            this.blockStack.Push(state);
        }

        private static bool IsStruct(Type objType)
        {
            if (objType.IsValueType)
            {
                return !objType.IsPrimitive;
            }
            return false;
        }

        public void Ldarg(int slot)
        {
            switch (slot)
            {
                case 0:
                    this.ilGen.Emit(OpCodes.Ldarg_0);
                    return;

                case 1:
                    this.ilGen.Emit(OpCodes.Ldarg_1);
                    return;

                case 2:
                    this.ilGen.Emit(OpCodes.Ldarg_2);
                    return;

                case 3:
                    this.ilGen.Emit(OpCodes.Ldarg_3);
                    return;
            }
            if (slot <= 0xff)
            {
                this.ilGen.Emit(OpCodes.Ldarg_S, slot);
            }
            else
            {
                this.ilGen.Emit(OpCodes.Ldarg, slot);
            }
        }

        public void Ldarg(ArgBuilder arg)
        {
            this.Ldarg(arg.Index);
        }

        public void Ldarga(int slot)
        {
            if (slot <= 0xff)
            {
                this.ilGen.Emit(OpCodes.Ldarga_S, slot);
            }
            else
            {
                this.ilGen.Emit(OpCodes.Ldarga, slot);
            }
        }

        public void Ldarga(ArgBuilder argBuilder)
        {
            this.Ldarga(argBuilder.Index);
        }

        public void LdargAddress(ArgBuilder argBuilder)
        {
            if (argBuilder.ArgType.IsValueType)
            {
                this.Ldarga(argBuilder);
            }
            else
            {
                this.Ldarg(argBuilder);
            }
        }

        public void Ldc(bool boolVar)
        {
            if (boolVar)
            {
                this.ilGen.Emit(OpCodes.Ldc_I4_1);
            }
            else
            {
                this.ilGen.Emit(OpCodes.Ldc_I4_0);
            }
        }

        public void Ldc(double d)
        {
            this.ilGen.Emit(OpCodes.Ldc_R8, d);
        }

        public void Ldc(int intVar)
        {
            switch (intVar)
            {
                case -1:
                    this.ilGen.Emit(OpCodes.Ldc_I4_M1);
                    return;

                case 0:
                    this.ilGen.Emit(OpCodes.Ldc_I4_0);
                    return;

                case 1:
                    this.ilGen.Emit(OpCodes.Ldc_I4_1);
                    return;

                case 2:
                    this.ilGen.Emit(OpCodes.Ldc_I4_2);
                    return;

                case 3:
                    this.ilGen.Emit(OpCodes.Ldc_I4_3);
                    return;

                case 4:
                    this.ilGen.Emit(OpCodes.Ldc_I4_4);
                    return;

                case 5:
                    this.ilGen.Emit(OpCodes.Ldc_I4_5);
                    return;

                case 6:
                    this.ilGen.Emit(OpCodes.Ldc_I4_6);
                    return;

                case 7:
                    this.ilGen.Emit(OpCodes.Ldc_I4_7);
                    return;

                case 8:
                    this.ilGen.Emit(OpCodes.Ldc_I4_8);
                    return;
            }
            this.ilGen.Emit(OpCodes.Ldc_I4, intVar);
        }

        public void Ldc(long l)
        {
            this.ilGen.Emit(OpCodes.Ldc_I8, l);
        }

        public void Ldc(object o)
        {
            Type enumType = o.GetType();
            if (o is Type)
            {
                this.Ldtoken((Type) o);
                this.Call(GetTypeFromHandle);
            }
            else if (enumType.IsEnum)
            {
                this.Ldc(((IConvertible) o).ToType(Enum.GetUnderlyingType(enumType), null));
            }
            else
            {
                switch (Type.GetTypeCode(enumType))
                {
                    case TypeCode.Boolean:
                        this.Ldc((bool) o);
                        return;

                    case TypeCode.Char:
                        //throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(new NotSupportedException(SR.GetString("CharIsInvalidPrimitive")));

                    case TypeCode.SByte:
                    case TypeCode.Byte:
                    case TypeCode.Int16:
                    case TypeCode.UInt16:
                        this.Ldc(((IConvertible) o).ToInt32(CultureInfo.InvariantCulture));
                        return;

                    case TypeCode.Int32:
                        this.Ldc((int) o);
                        return;

                    case TypeCode.UInt32:
                        this.Ldc((int) ((uint) o));
                        return;

                    case TypeCode.Int64:
                        this.Ldc((long) o);
                        return;

                    case TypeCode.UInt64:
                        this.Ldc((long) ((ulong) o));
                        return;

                    case TypeCode.Single:
                        this.Ldc((float) o);
                        return;

                    case TypeCode.Double:
                        this.Ldc((double) o);
                        return;

                    case TypeCode.String:
                        this.Ldstr((string) o);
                        return;
                }
                throw new Exception("UnknownConstantType");
            }
        }

        public void Ldc(float f)
        {
            this.ilGen.Emit(OpCodes.Ldc_R4, f);
        }

        public void Ldelem(Type arrayElementType)
        {
            if (arrayElementType.IsEnum)
            {
                this.Ldelem(Enum.GetUnderlyingType(arrayElementType));
            }
            else
            {
                OpCode opcode = this.GetLdelemOpCode(Type.GetTypeCode(arrayElementType));
                if (opcode.Equals(OpCodes.Nop))
                {
                    throw new Exception("ArrayTypeIsNotSupported");
                }
                this.ilGen.Emit(opcode);
            }
        }

        public void Ldelema(Type arrayElementType)
        {
            OpCode opcode = OpCodes.Ldelema;
            this.ilGen.Emit(opcode, arrayElementType);
        }

        public void Ldlen()
        {
            this.ilGen.Emit(OpCodes.Ldlen);
            this.ilGen.Emit(OpCodes.Conv_I4);
        }

        public void Ldloc(int slot)
        {
            switch (slot)
            {
                case 0:
                    this.ilGen.Emit(OpCodes.Ldloc_0);
                    return;

                case 1:
                    this.ilGen.Emit(OpCodes.Ldloc_1);
                    return;

                case 2:
                    this.ilGen.Emit(OpCodes.Ldloc_2);
                    return;

                case 3:
                    this.ilGen.Emit(OpCodes.Ldloc_3);
                    return;
            }
            if (slot <= 0xff)
            {
                this.ilGen.Emit(OpCodes.Ldloc_S, slot);
            }
            else
            {
                this.ilGen.Emit(OpCodes.Ldloc, slot);
            }
        }

        public void Ldloc(LocalBuilder localBuilder)
        {
            this.ilGen.Emit(OpCodes.Ldloc, localBuilder);
        }

        public void Ldloca(int slot)
        {
            if (slot <= 0xff)
            {
                this.ilGen.Emit(OpCodes.Ldloca_S, slot);
            }
            else
            {
                this.ilGen.Emit(OpCodes.Ldloca, slot);
            }
        }

        public void Ldloca(LocalBuilder localBuilder)
        {
            this.ilGen.Emit(OpCodes.Ldloca, localBuilder);
        }

        public void LdlocAddress(LocalBuilder localBuilder)
        {
            if (localBuilder.LocalType.IsValueType)
            {
                this.Ldloca(localBuilder);
            }
            else
            {
                this.Ldloc(localBuilder);
            }
        }

        public void Ldobj(Type type)
        {
            OpCode opcode = this.GetLdindOpCode(Type.GetTypeCode(type));
            if (!opcode.Equals(OpCodes.Nop))
            {
                this.ilGen.Emit(opcode);
            }
            else
            {
                this.ilGen.Emit(OpCodes.Ldobj, type);
            }
        }

        public void Ldstr(string strVar)
        {
            this.ilGen.Emit(OpCodes.Ldstr, strVar);
        }

        public void Ldtoken(Type t)
        {
            this.ilGen.Emit(OpCodes.Ldtoken, t);
        }

        public void Load(object obj)
        {
            if (obj == null)
            {
                this.ilGen.Emit(OpCodes.Ldnull);
            }
            else if (obj is ArgBuilder)
            {
                this.Ldarg((ArgBuilder) obj);
            }
            else if (obj is LocalBuilder)
            {
                this.Ldloc((LocalBuilder) obj);
            }
            else
            {
                this.Ldc(obj);
            }
        }

        public void LoadAddress(object obj)
        {
            if (obj is ArgBuilder)
            {
                this.LdargAddress((ArgBuilder) obj);
            }
            else if (obj is LocalBuilder)
            {
                this.LdlocAddress((LocalBuilder) obj);
            }
            else
            {
                this.Load(obj);
            }
        }

        public void LoadArrayElement(object obj, object arrayIndex)
        {
            Type objType = this.GetVariableType(obj).GetElementType();
            this.Load(obj);
            this.Load(arrayIndex);
            if (IsStruct(objType))
            {
                this.Ldelema(objType);
                this.Ldobj(objType);
            }
            else
            {
                this.Ldelem(objType);
            }
        }

        public void LoadDefaultValue(Type type)
        {
            if (!type.IsValueType)
            {
                this.Load(null);
            }
            else
            {
                switch (Type.GetTypeCode(type))
                {
                    case TypeCode.Boolean:
                        this.Ldc(false);
                        return;

                    case TypeCode.Char:
                    case TypeCode.SByte:
                    case TypeCode.Byte:
                    case TypeCode.Int16:
                    case TypeCode.UInt16:
                    case TypeCode.Int32:
                    case TypeCode.UInt32:
                        this.Ldc(0);
                        return;

                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                        this.Ldc((long) 0);
                        return;

                    case TypeCode.Single:
                        this.Ldc((float) 0f);
                        return;

                    case TypeCode.Double:
                        this.Ldc((double) 0);
                        return;
                }
                LocalBuilder builder = this.DeclareLocal(type, "zero");
                this.LoadAddress(builder);
                this.InitObj(type);
                this.Load(builder);
            }
        }

        public Type LoadMember(MemberInfo memberInfo)
        {
            Type stackTopType = null;
            if (memberInfo.MemberType == MemberTypes.Field)
            {
                FieldInfo field = (FieldInfo) memberInfo;
                stackTopType = field.FieldType;
                if (field.IsStatic)
                {
                    this.ilGen.Emit(OpCodes.Ldsfld, field);
                }
                else
                {
                    this.ilGen.Emit(OpCodes.Ldfld, field);
                }
            }
            else if (memberInfo.MemberType == MemberTypes.Property)
            {
                PropertyInfo info2 = memberInfo as PropertyInfo;
                stackTopType = info2.PropertyType;
                if (info2 != null)
                {
                    MethodInfo methodInfo = info2.GetGetMethod(true);
                    if (methodInfo == null)
                    {
                        throw new Exception("NoGetMethodForProperty");
                    }
                    this.Call(methodInfo);
                }
            }
            else
            {
                if (memberInfo.MemberType != MemberTypes.Method)
                {
                    throw new Exception("CannotLoadMemberType");
                }
                MethodInfo info4 = (MethodInfo) memberInfo;
                stackTopType = info4.ReturnType;
                this.Call(info4);
            }
            return stackTopType;
        }

        private void LoadParam(object arg, int oneBasedArgIndex, MethodBase methodInfo)
        {
            this.Load(arg);
            if (arg != null)
            {
                this.ConvertValue(this.GetVariableType(arg), methodInfo.GetParameters()[oneBasedArgIndex - 1].ParameterType);
            }
        }

        private void LoadThis(object thisObj, MethodInfo methodInfo)
        {
            if ((thisObj != null) && !methodInfo.IsStatic)
            {
                this.LoadAddress(thisObj);
                this.ConvertAddress(this.GetVariableType(thisObj), methodInfo.DeclaringType);
            }
        }

        public void MarkLabel(Label label)
        {
            this.ilGen.MarkLabel(label);
        }

        public void New(ConstructorInfo constructorInfo)
        {
            this.ilGen.Emit(OpCodes.Newobj, constructorInfo);
        }

        public void New(ConstructorInfo constructorInfo, object param1)
        {
            this.LoadParam(param1, 1, constructorInfo);
            this.New(constructorInfo);
        }

        public void NewArray(Type elementType, object len)
        {
            this.Load(len);
            this.ilGen.Emit(OpCodes.Newarr, elementType);
        }

        public void Not()
        {
            this.ilGen.Emit(OpCodes.Not);
        }

        public void Or()
        {
            this.ilGen.Emit(OpCodes.Or);
        }

        public void Pop()
        {
            this.ilGen.Emit(OpCodes.Pop);
        }

        private IfState PopIfState()
        {
            object expected = this.blockStack.Pop();
            IfState state = expected as IfState;
            if (state == null)
            {
                this.ThrowMismatchException(expected);
            }
            return state;
        }

        public void Ret()
        {
            this.ilGen.Emit(OpCodes.Ret);
        }

        public void Set(LocalBuilder local, object value)
        {
            this.Load(value);
            this.Store(local);
        }

        public void Starg(int slot)
        {
            if (slot <= 0xff)
            {
                this.ilGen.Emit(OpCodes.Starg_S, slot);
            }
            else
            {
                this.ilGen.Emit(OpCodes.Starg, slot);
            }
        }

        public void Starg(ArgBuilder arg)
        {
            this.Starg(arg.Index);
        }

        public void Stelem(Type arrayElementType)
        {
            if (arrayElementType.IsEnum)
            {
                this.Stelem(Enum.GetUnderlyingType(arrayElementType));
            }
            else
            {
                OpCode opcode = this.GetStelemOpCode(Type.GetTypeCode(arrayElementType));
                if (opcode.Equals(OpCodes.Nop))
                {
                    throw new Exception("ArrayTypeIsNotSupported");
                }
                this.ilGen.Emit(opcode);
            }
        }

        public void Stloc(int slot)
        {
            switch (slot)
            {
                case 0:
                    this.ilGen.Emit(OpCodes.Stloc_0);
                    return;

                case 1:
                    this.ilGen.Emit(OpCodes.Stloc_1);
                    return;

                case 2:
                    this.ilGen.Emit(OpCodes.Stloc_2);
                    return;

                case 3:
                    this.ilGen.Emit(OpCodes.Stloc_3);
                    return;
            }
            if (slot <= 0xff)
            {
                this.ilGen.Emit(OpCodes.Stloc_S, slot);
            }
            else
            {
                this.ilGen.Emit(OpCodes.Stloc, slot);
            }
        }

        public void Stloc(LocalBuilder local)
        {
            this.ilGen.Emit(OpCodes.Stloc, local);
        }

        public void Stobj(Type type)
        {
            this.ilGen.Emit(OpCodes.Stobj, type);
        }

        public void Store(object var)
        {
            if (var is ArgBuilder)
            {
                this.Starg((ArgBuilder) var);
            }
            else
            {
                if (!(var is LocalBuilder))
                {
                    throw new Exception("CanOnlyStoreIntoArgOrLocGot0");
                }
                this.Stloc((LocalBuilder) var);
            }
        }

        public void StoreArrayElement(object obj, object arrayIndex, object value)
        {
            Type variableType = this.GetVariableType(obj);
            Type objType = (variableType == Globals.TypeOfArray) ? Globals.TypeOfObject : variableType.GetElementType();
            this.Load(obj);
            this.Load(arrayIndex);
            if (IsStruct(objType))
            {
                this.Ldelema(objType);
            }
            this.Load(value);
            this.ConvertValue(this.GetVariableType(value), objType);
            if (IsStruct(objType))
            {
                this.Stobj(objType);
            }
            else
            {
                this.Stelem(objType);
            }
        }

        public void StoreMember(MemberInfo memberInfo)
        {
            if (memberInfo.MemberType == MemberTypes.Field)
            {
                FieldInfo field = (FieldInfo) memberInfo;
                if (field.IsStatic)
                {
                    this.ilGen.Emit(OpCodes.Stsfld, field);
                }
                else
                {
                    this.ilGen.Emit(OpCodes.Stfld, field);
                }
            }
            else if (memberInfo.MemberType == MemberTypes.Property)
            {
                PropertyInfo info2 = memberInfo as PropertyInfo;
                if (info2 != null)
                {
                    MethodInfo methodInfo = info2.GetSetMethod(true);
                    if (methodInfo == null)
                    {
                        throw new Exception("NoSetMethodForProperty");
                    }
                    this.Call(methodInfo);
                }
            }
            else
            {
                if (memberInfo.MemberType != MemberTypes.Method)
                {
                    throw new Exception("CannotLoadMemberType");
                }
                this.Call((MethodInfo) memberInfo);
            }
        }

        public void Subtract()
        {
            this.ilGen.Emit(OpCodes.Sub);
        }

        public Label[] Switch(int labelCount)
        {
            SwitchState state = new SwitchState(this.DefineLabel(), this.DefineLabel());
            Label[] labels = new Label[labelCount];
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = this.DefineLabel();
            }
            this.ilGen.Emit(OpCodes.Switch, labels);
            this.Br(state.DefaultLabel);
            this.blockStack.Push(state);
            return labels;
        }

        public void Throw()
        {
            this.ilGen.Emit(OpCodes.Throw);
        }

        private void ThrowMismatchException(object expected)
        {
            throw new Exception("ExpectingEnd");
        }

        public void ToString(Type type)
        {
            if (type.IsValueType)
            {
                this.Box(type);
                this.Call(ObjectToString);
            }
            else
            {
                this.Dup();
                this.Load(null);
                this.If(Cmp.EqualTo);
                this.Pop();
                this.Load("<null>");
                this.Else();
                if (type.IsArray)
                {
                    LocalBuilder var = this.DeclareLocal(type, "arrayVar");
                    this.Store(var);
                    this.Load("{ ");
                    LocalBuilder builder2 = this.DeclareLocal(typeof(string), "arrayValueString");
                    this.Store(builder2);
                    LocalBuilder local = this.DeclareLocal(typeof(int), "i");
                    this.For(local, 0, var);
                    this.Load(builder2);
                    this.LoadArrayElement(var, local);
                    this.ToString(var.LocalType.GetElementType());
                    this.Load(", ");
                    this.Concat3();
                    this.Store(builder2);
                    this.EndFor();
                    this.Load(builder2);
                    this.Load("}");
                    this.Concat2();
                }
                else
                {
                    this.Call(ObjectToString);
                }
                this.EndIf();
            }
        }

        public void Unbox(Type type)
        {
            this.ilGen.Emit(OpCodes.Unbox, type);
        }

        public void UnboxAny(Type type)
        {
            this.ilGen.Emit(OpCodes.Unbox_Any, type);
        }

        public void VerifyParameterCount(MethodInfo methodInfo, int expectedCount)
        {
            if (methodInfo.GetParameters().Length != expectedCount)
            {
                throw new Exception("ParameterCountMismatch");
            }
        }

        // Properties
        public MethodInfo CurrentMethod
        {
            get
            {
                return this.dynamicMethod;
            }
        }

        public ILGenerator InternalILGenerator
        {
            get
            {
                return this.ilGen;
            }
        }

        public Module SerializationModule
        {
            get
            {
                return this.serializationModule;
            }
        }

        private static MethodInfo GetTypeFromHandle
        {
            get
            {
                if (getTypeFromHandle == null)
                {
                    getTypeFromHandle = typeof(Type).GetMethod("GetTypeFromHandle");
                }
                return getTypeFromHandle;
            }
        }

        private Hashtable LocalNames
        {
            get
            {
                if (this.localNames == null)
                {
                    this.localNames = new Hashtable();
                }
                return this.localNames;
            }
        }

        private static MethodInfo ObjectEquals
        {
            get
            {
                if (objectEquals == null)
                {
                    objectEquals = Globals.TypeOfObject.GetMethod("Equals", BindingFlags.Public | BindingFlags.Static);
                }
                return objectEquals;
            }
        }

        private static MethodInfo ObjectToString
        {
            get
            {
                if (objectToString == null)
                {
                    objectToString = typeof(object).GetMethod("ToString", new Type[0]);
                }
                return objectToString;
            }
        }

        private static MethodInfo StringConcat2
        {
            get
            {
                if (stringConcat2 == null)
                {
                    stringConcat2 = typeof(string).GetMethod("Concat", new Type[] { typeof(string), typeof(string) });
                }
                return stringConcat2;
            }
        }

        private static MethodInfo StringConcat3
        {
            get
            {
                if (stringConcat3 == null)
                {
                    stringConcat3 = typeof(string).GetMethod("Concat", new Type[] { typeof(string), typeof(string), typeof(string) });
                }
                return stringConcat3;
            }
        }

        private static MethodInfo StringFormat
        {
            get
            {
                if (stringFormat == null)
                {
                    stringFormat = typeof(string).GetMethod("Format", new Type[] { typeof(string), typeof(object[]) });
                }
                return stringFormat;
            }
        }
    }
}
