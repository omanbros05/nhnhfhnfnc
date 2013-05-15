using System;
using System.Text;
using System.Data;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace NBear.Mapping
{
    /// <summary>
    /// 	NameValueSetterGenerator
    /// </summary>
    internal class NameValueSetterGenerator : IMemberSetterGenerator
    {
        #region IMemberSetterGenerator Members

        public void BeginSetMembers(CodeGenerator generator, ArgBuilder targetObject)
        {

        }

        public void SetMemberValue(CodeGenerator generator, ArgBuilder targetObject, string memberName, LocalBuilder memberValue)
        {
            generator.Ldarg(targetObject);
            generator.Load(memberName);
            generator.Ldloc(memberValue);

            // Type originalType = memberValue.LocalType.IsEnum ? typeof(int) : memberValue.LocalType;
            if (memberValue.LocalType.IsValueType)
            {
                generator.Box(memberValue.LocalType.IsEnum ? typeof(int) : memberValue.LocalType);
            }
            //如果值为空，则不能调用ToString
            generator.Load(null);
            generator.If(Cmp.NotEqualTo);
            generator.Ldloc(memberValue);

            // Type originalType = memberValue.LocalType.IsEnum ? typeof(int) : memberValue.LocalType;
            if (memberValue.LocalType.IsValueType)
            {
                generator.Box(memberValue.LocalType.IsEnum ? typeof(int) : memberValue.LocalType);
            }
            generator.Call(typeof(object).GetMethod("ToString", Type.EmptyTypes));
            generator.Else();
            generator.LoadDefaultValue(memberValue.LocalType);
            if (memberValue.LocalType.IsValueType)
            {
                generator.Box(memberValue.LocalType.IsEnum ? typeof(int) : memberValue.LocalType);
            }
            generator.EndIf();
            generator.Call(typeof(NameValueCollection).GetMethod("Add", new Type[] { typeof(string), typeof(string) }));
        }

        public void EndSetMembers(CodeGenerator generator, ArgBuilder targetObject)
        {

        }

        #endregion

        #region IMemberSetterGenerator Members

        public bool ContainsMember(string name, Type type, object outputObject)
        {
            return true;
        }

        #endregion
    }
}
