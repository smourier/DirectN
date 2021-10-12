// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmeapi.h(2220,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMIXERLINECONTROLSA
    {
        public uint cbStruct;
        public uint dwLineID;
        public tagMIXERLINECONTROLSA__union_0 __union_2;
        public uint cControls;
        public uint cbmxctrl;
        public IntPtr pamxctrl;
    }
}
