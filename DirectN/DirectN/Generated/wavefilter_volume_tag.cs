// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\mmreg.h(3462,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct wavefilter_volume_tag
    {
        public wavefilter_tag wfltr;
        public uint dwVolume;
    }
}
