//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\wlansvc.dll
// Interface ID: 266f33b4-c7c1-4bd1-8f52-ddb8f2214eb0
// Interface Version: 1.0



namespace rpc_266f33b4_c7c1_4bd1_8f52_ddb8f2214eb0_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(Union_7 p0)
        {
            WriteStruct<Union_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(Struct_9 p0)
        {
            WriteStruct<Struct_9>(p0);
        }
        public void Write_9(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_10(Struct_3[] p0, long p1)
        {
            WriteConformantArray<Struct_3>(p0, p1);
        }
        public void Write_11(string p0)
        {
            WriteFixedString(p0, 256);
        }
        public void Write_12(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 6);
        }
        public void Write_13(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 112);
        }
        public void Write_14(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_15(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public Union_7 Read_6()
        {
            return ReadStruct<Union_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public Struct_9 Read_8()
        {
            return ReadStruct<Struct_9>();
        }
        public sbyte[] Read_9()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_3[] Read_10()
        {
            return ReadConformantArray<Struct_3>();
        }
        public string Read_11()
        {
            return ReadFixedString(256);
        }
        public sbyte[] Read_12()
        {
            return ReadFixedPrimitiveArray<sbyte>(6);
        }
        public sbyte[] Read_13()
        {
            return ReadFixedPrimitiveArray<sbyte>(112);
        }
        public sbyte[] Read_14()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_15()
        {
            return ReadConformantArray<sbyte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteGuid(Member8);
            m.WriteInt32(Member18);
            m.WriteEmbeddedPointer<sbyte[], long>(Member20, new System.Action<sbyte[], long>(m.Write_9), Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadGuid();
            Member18 = u.ReadInt32();
            Member20 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_9), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public System.Guid Member8;
        public int Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member20;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, int Member4, System.Guid Member8, int Member18, sbyte[] Member20)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member18 = Member18;
            this.Member20 = Member20;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.Read_10();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public Struct_3[] Member8;
        public static Struct_2 CreateDefault()
        {
            Struct_2 ret = new Struct_2();
            ret.Member8 = new Struct_3[0];
            return ret;
        }
        public Struct_2(int Member0, int Member4, Struct_3[] Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteGuid(Member0);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member10, "Member10"));
            m.WriteInt32(Member210);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.Read_11();
            Member210 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public System.Guid Member0;
        public string Member10;
        public int Member210;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member10 = new string('\0', 256);
            return ret;
        }
        public Struct_3(System.Guid Member0, string Member10, int Member210)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member210 = Member210;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_12(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_12();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public sbyte[] Member0;
        public static Struct_4 CreateDefault()
        {
            Struct_4 ret = new Struct_4();
            ret.Member0 = new sbyte[6];
            return ret;
        }
        public Struct_4(sbyte[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_5(Member0);
            m.Write_5(Member80);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_5();
            Member80 = u.Read_5();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public Struct_6 Member0;
        public Struct_6 Member80;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(Struct_6 Member0, Struct_6 Member80)
        {
            this.Member0 = Member0;
            this.Member80 = Member80;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
            m.Write_12(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member2, "Member2"));
            m.WriteInt64(Member8);
            m.Write_13(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member10, "Member10"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.Read_12();
            Member8 = u.ReadInt64();
            Member10 = u.Read_13();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public short Member0;
        public sbyte[] Member2;
        public long Member8;
        public sbyte[] Member10;
        public static Struct_6 CreateDefault()
        {
            Struct_6 ret = new Struct_6();
            ret.Member2 = new sbyte[6];
            ret.Member10 = new sbyte[112];
            return ret;
        }
        public Struct_6(short Member0, sbyte[] Member2, long Member8, sbyte[] Member10)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    public struct Union_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Selector);
            if ((Selector == 0))
            {
                m.Write_7(Arm_0);
                goto done;
            }
            if ((Selector == 2))
            {
                m.Write_7(Arm_2);
                goto done;
            }
            if ((Selector == 1))
            {
                m.Write_8(Arm_1);
                goto done;
            }
            throw new System.ArgumentException("No matching union selector when marshaling Union_7");
        done:
            return;
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Selector = u.ReadEnum16();
            if ((Selector == 0))
            {
                Arm_0 = u.Read_7();
                goto done;
            }
            if ((Selector == 2))
            {
                Arm_2 = u.Read_7();
                goto done;
            }
            if ((Selector == 1))
            {
                Arm_1 = u.Read_8();
                goto done;
            }
            throw new System.ArgumentException("No matching union selector when marshaling Union_7");
        done:
            return;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector;
        public Struct_8 Arm_0;
        public Struct_8 Arm_2;
        public Struct_9 Arm_1;
        public static Union_7 CreateDefault()
        {
            return new Union_7();
        }
        public Union_7(NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector, Struct_8 Arm_0, Struct_8 Arm_2, Struct_9 Arm_1)
        {
            this.Selector = Selector;
            this.Arm_0 = Arm_0;
            this.Arm_2 = Arm_2;
            this.Arm_1 = Arm_1;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public short Member0;
        public static Struct_8 CreateDefault()
        {
            return new Struct_8();
        }
        public Struct_8(short Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteSByte(Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadSByte();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public sbyte Member0;
        public static Struct_9 CreateDefault()
        {
            return new Struct_9();
        }
        public Struct_9(sbyte Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("266f33b4-c7c1-4bd1-8f52-ddb8f2214eb0", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcLowPrivOpenHandle(char p0, int p1, ref int p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteChar(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadInt32();
            p3 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcLowPrivCloseHandle(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcLowPrivRegisterNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        // async
        public int RpcLowPrivAsyncGetNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_0> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.ReadReferentValue<Struct_0>(new System.Func<Struct_0>(u.Read_0), false);
            return u.ReadInt32();
        }
        public int RpcLowPrivSetInterface(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, int p2, int p3, sbyte[] p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int RpcLowPrivQueryInterface(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1, int p2, out int p3, out sbyte[] p4, out int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(5, m);
            p3 = u.ReadInt32();
            p4 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_15), false);
            p5 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcLowPrivEnumInterfaces(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_2> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadReferentValue<Struct_2>(new System.Func<Struct_2>(u.Read_1), false);
            return u.ReadInt32();
        }
        public int RpcWfdLowPrivIsWfdSupported(char p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteChar(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcWfdLowPrivOpenHandle(char p0, int p1, ref int p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteChar(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(8, m);
            p2 = u.ReadInt32();
            p3 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        // async
        public int RpcWfdLowPrivOpenSessionByInterfaceId(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, int p2, out System.Guid p3, out Struct_4 p4, out int p5, out NtApiDotNet.Ndr.Marshal.NdrUInt3264 p6, NtApiDotNet.Ndr.Marshal.NdrEnum16 p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInt32(p2);
            m.WriteEnum16(p7);
            _Unmarshal_Helper u = SendReceive(9, m);
            p3 = u.ReadGuid();
            p4 = u.Read_3();
            p5 = u.ReadInt32();
            p6 = u.ReadUInt3264();
            return u.ReadInt32();
        }
        public int RpcWfdLowPrivCancelOpenSession(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        // async
        public int RpcWfdLowPrivCloseSession(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteUInt3264(p1);
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
        public int RpcWfdLowPrivGetSessionEndpointPairs(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1, out Struct_5 p2, out Struct_5 p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteUInt3264(p1);
            _Unmarshal_Helper u = SendReceive(12, m);
            p2 = u.Read_4();
            p3 = u.Read_4();
            return u.ReadInt32();
        }
        public int RpcWfdLowPrivConfigureFirewallForSession(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1, Union_7 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteUInt3264(p1);
            m.Write_6(p2);
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

