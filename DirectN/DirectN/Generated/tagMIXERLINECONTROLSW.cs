// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMIXERLINECONTROLSW
    {
        public uint cbStruct;
        public uint dwLineID;
        public tagMIXERLINECONTROLSW__union_0 __union_2;
        public uint cControls;
        public uint cbmxctrl;
        public IntPtr pamxctrl;
    }
}
