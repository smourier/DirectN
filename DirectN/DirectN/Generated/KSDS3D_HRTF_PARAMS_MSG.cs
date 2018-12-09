// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(1228,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDS3D_HRTF_PARAMS_MSG
    {
        public uint Size;
        public uint Enabled;
        public bool SwapChannels;
        public bool ZeroAzimuth;
        public bool CrossFadeOutput;
        public uint FilterSize;
    }
}
