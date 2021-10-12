// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dvdmedia.h(115,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AM_PROPERTY_SPHLI
    {
        public ushort HLISS;
        public ushort Reserved;
        public uint StartPTM;
        public uint EndPTM;
        public ushort StartX;
        public ushort StartY;
        public ushort StopX;
        public ushort StopY;
        public _AM_COLCON ColCon;
    }
}
