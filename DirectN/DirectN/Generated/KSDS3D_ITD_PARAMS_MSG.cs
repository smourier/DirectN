// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDS3D_ITD_PARAMS_MSG
    {
        public uint Enabled;
        public KSDS3D_ITD_PARAMS LeftParams;
        public KSDS3D_ITD_PARAMS RightParams;
        public uint Reserved;
    }
}
