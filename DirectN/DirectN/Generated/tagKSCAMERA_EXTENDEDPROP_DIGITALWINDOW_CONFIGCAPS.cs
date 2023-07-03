// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(6614,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_DIGITALWINDOW_CONFIGCAPS
    {
        public int ResolutionX;
        public int ResolutionY;
        public int PorchTop;
        public int PorchLeft;
        public int PorchBottom;
        public int PorchRight;
        public int NonUpscalingWindowSize;
        public int MinWindowSize;
        public int MaxWindowSize;
        public int Reserved;
    }
}
