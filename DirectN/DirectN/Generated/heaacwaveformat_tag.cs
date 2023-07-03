// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\mmreg.h(3206,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct heaacwaveformat_tag
    {
        public heaacwaveinfo_tag wfInfo;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] pbAudioSpecificConfig;
    }
}
