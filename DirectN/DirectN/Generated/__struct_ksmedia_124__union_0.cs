// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(6652,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct __struct_ksmedia_124__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public tagDEVCAPS Capabilities { get => InteropRuntime.Get<tagDEVCAPS>(__bits, 0, 736); set => InteropRuntime.Set<tagDEVCAPS>(value, __bits, 0, 736); }
        public uint DevPort { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
        public uint PowerState { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
        public string pawchString { get => InteropRuntime.GetString(__bits, 0, 2080); set => InteropRuntime.SetString(value, __bits, 0, 2080); }
        public uint[] NodeUniqueID { get => InteropRuntime.GetArray<uint>(__bits, 0, 64); set => InteropRuntime.SetArray<uint>(value, __bits, 0, 64); }
    }
}
