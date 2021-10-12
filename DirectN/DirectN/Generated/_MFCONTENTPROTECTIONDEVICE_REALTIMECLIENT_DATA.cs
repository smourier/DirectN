// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(18302,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA
    {
        public uint TaskIndex;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string ClassName;
        public int BasePriority;
    }
}
