// generated from <Windows SDK Path>\shared\ksmedia.h
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
