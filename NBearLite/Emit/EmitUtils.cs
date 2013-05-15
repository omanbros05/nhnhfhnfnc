using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace NBearLite.Emit
{
    public sealed class EmitUtils
    {
        private EmitUtils() { }

        public static void LoadInt32(ILGenerator gen, int value)
        {
            if (gen == null)
            {
                throw new ArgumentNullException("gen");
            }

            switch (value)
            {
                case -1:
                    gen.Emit(OpCodes.Ldc_I4_M1);
                    break;
                case 0:
                    gen.Emit(OpCodes.Ldc_I4_0);
                    break;
                case 1:
                    gen.Emit(OpCodes.Ldc_I4_1);
                    break;
                case 2:
                    gen.Emit(OpCodes.Ldc_I4_2);
                    break;
                case 3:
                    gen.Emit(OpCodes.Ldc_I4_3);
                    break;
                case 4:
                    gen.Emit(OpCodes.Ldc_I4_4);
                    break;
                case 5:
                    gen.Emit(OpCodes.Ldc_I4_5);
                    break;
                case 6:
                    gen.Emit(OpCodes.Ldc_I4_6);
                    break;
                case 7:
                    gen.Emit(OpCodes.Ldc_I4_7);
                    break;
                case 8:
                    gen.Emit(OpCodes.Ldc_I4_8);
                    break;
                default:
                    if (value > -129 && value < 128)
                    {
                        gen.Emit(OpCodes.Ldc_I4_S, (SByte)value);
                    }
                    else
                    {
                        gen.Emit(OpCodes.Ldc_I4, value);
                    }
                    break;
            }
        }

        public static void StoreLocal(ILGenerator gen, int index)
        {
            if (gen == null)
            {
                throw new ArgumentNullException("gen");
            }

            switch (index)
            {
                case 0:
                    gen.Emit(OpCodes.Stloc_0);
                    break;
                case 1:
                    gen.Emit(OpCodes.Stloc_1);
                    break;
                case 2:
                    gen.Emit(OpCodes.Stloc_2);
                    break;
                case 3:
                    gen.Emit(OpCodes.Stloc_3);
                    break;
                default:
                    if (index < 256)
                    {
                        gen.Emit(OpCodes.Stloc_S, index);
                    }
                    else
                    {
                        gen.Emit(OpCodes.Stloc, index);
                    }
                    break;
            }
        }

        public static void LoadLocal(ILGenerator gen, int index)
        {
            if (gen == null)
            {
                throw new ArgumentNullException("gen");
            }

            switch (index)
            {
                case 0:
                    gen.Emit(OpCodes.Ldloc_0);
                    break;
                case 1:
                    gen.Emit(OpCodes.Ldloc_1);
                    break;
                case 2:
                    gen.Emit(OpCodes.Ldloc_2);
                    break;
                case 3:
                    gen.Emit(OpCodes.Ldloc_3);
                    break;
                default:
                    if (index < 256)
                    {
                        gen.Emit(OpCodes.Ldloc_S, index);
                    }
                    else
                    {
                        gen.Emit(OpCodes.Ldloc, index);
                    }
                    break;
            }
        }

        public static void LoadLocalAddress(ILGenerator gen, int index)
        {
            if (gen == null)
            {
                throw new ArgumentNullException("gen");
            }

            if (index < 256)
                gen.Emit(OpCodes.Ldloca_S, (byte)index);
            else
                gen.Emit(OpCodes.Ldloca, index);
        }

        public static void LoadArgument(ILGenerator gen, int index)
        {
            if (gen == null)
            {
                throw new ArgumentNullException("gen");
            }

            switch (index)
            {
                case 0:
                    gen.Emit(OpCodes.Ldarg_0);
                    break;
                case 1:
                    gen.Emit(OpCodes.Ldarg_1);
                    break;
                case 2:
                    gen.Emit(OpCodes.Ldarg_2);
                    break;
                case 3:
                    gen.Emit(OpCodes.Ldarg_3);
                    break;
                default:
                    if (index < 256)
                        gen.Emit(OpCodes.Ldarg_S, (byte)index);
                    else
                        gen.Emit(OpCodes.Ldarg, index);
                    break;
            }
        }

        public static void LoadArgumentAddress(ILGenerator gen, int index)
        {
            if (gen == null)
            {
                throw new ArgumentNullException("gen");
            }

            if (index < 256)
                gen.Emit(OpCodes.Ldarga_S, (byte)index);
            else
                gen.Emit(OpCodes.Ldarga, index);
        }

        public static void Call(ILGenerator gen, MethodInfo method)
        {
            if (gen == null)
            {
                throw new ArgumentNullException("gen");
            }

            if (method == null)
            {
                throw new ArgumentNullException("method");
            }

            if (method.IsFinal || !method.IsVirtual)
            {
                gen.EmitCall(OpCodes.Call, method, null);
            }
            else
            {
                gen.EmitCall(OpCodes.Callvirt, method, null);
            }
        }

        public static void StoreIndirectly(ILGenerator gen, Type type)
        {
            if (gen == null)
            {
                throw new ArgumentNullException("gen");
            }

            if (type == typeof(sbyte) || type == typeof(byte))
            {
                gen.Emit(OpCodes.Stind_I1);
            }
            else if (type == typeof(Int16) || type == typeof(UInt16))
            {
                gen.Emit(OpCodes.Stind_I2);
            }
            else if (type == typeof(Int32) || type == typeof(UInt32))
            {
                gen.Emit(OpCodes.Stind_I4);
            }
            else if (type == typeof(Int64) || type == typeof(UInt64))
            {
                gen.Emit(OpCodes.Stind_I8);
            }
            else if (type == typeof(float))
            {
                gen.Emit(OpCodes.Stind_R4);
            }
            else if (type == typeof(double))
            {
                gen.Emit(OpCodes.Stind_R8);
            }
            else
            {
                gen.Emit(OpCodes.Stind_Ref);
            }
        }

        public static void LoadIndirectly(ILGenerator gen, Type type)
        {
            if (gen == null)
            {
                throw new ArgumentNullException("gen");
            }

            if (type == typeof(sbyte))
            {
                gen.Emit(OpCodes.Ldind_I1);
            }
            else if (type == typeof(Int16))
            {
                gen.Emit(OpCodes.Ldind_I2);
            }
            else if (type == typeof(Int32))
            {
                gen.Emit(OpCodes.Ldind_I4);
            }
            else if (type == typeof(Int64))
            {
                gen.Emit(OpCodes.Ldind_I8);
            }
            else if (type == typeof(float))
            {
                gen.Emit(OpCodes.Ldind_R4);
            }
            else if (type == typeof(double))
            {
                gen.Emit(OpCodes.Ldind_R8);
            }
            else if (type == typeof(byte))
            {
                gen.Emit(OpCodes.Ldind_U1);
            }
            else if (type == typeof(UInt16))
            {
                gen.Emit(OpCodes.Ldind_U2);
            }
            else if (type == typeof(UInt32))
            {
                gen.Emit(OpCodes.Ldind_U4);
            }
            else
            {
                gen.Emit(OpCodes.Ldind_Ref);
            }
        }
    }
}
