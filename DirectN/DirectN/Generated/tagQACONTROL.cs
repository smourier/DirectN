// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(6890,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagQACONTROL
    {
        public uint cbSize;
        public uint dwMiscStatus;
        public uint dwViewStatus;
        public uint dwEventCookie;
        public uint dwPropNotifyCookie;
        public uint dwPointerActivationPolicy;
    }
}
