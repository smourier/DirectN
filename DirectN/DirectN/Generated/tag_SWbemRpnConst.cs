// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmiutils.h(1040,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tag_SWbemRpnConst
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public string m_pszStrVal { get => InteropRuntime.GetString(__bits, 0, 64); set => InteropRuntime.SetString(value, __bits, 0, 64); }
        public bool m_bBoolVal { get => InteropRuntime.GetBoolean(__bits, 0, 32); set => InteropRuntime.SetBoolean(value, __bits, 0, 32); }
        public int m_lLongVal { get => InteropRuntime.GetInt32(__bits, 0, 32); set => InteropRuntime.SetInt32(value, __bits, 0, 32); }
        public uint m_uLongVal { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
        public double m_dblVal { get => InteropRuntime.GetDouble(__bits, 0, 64); set => InteropRuntime.SetDouble(value, __bits, 0, 64); }
        public long m_lVal64 { get => InteropRuntime.GetInt64(__bits, 0, 64); set => InteropRuntime.SetInt64(value, __bits, 0, 64); }
        public long m_uVal64 { get => InteropRuntime.GetInt64(__bits, 0, 64); set => InteropRuntime.SetInt64(value, __bits, 0, 64); }
    }
}
