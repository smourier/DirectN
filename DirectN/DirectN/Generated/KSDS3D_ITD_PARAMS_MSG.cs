// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(1307,9)
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
