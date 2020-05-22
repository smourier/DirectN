// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(769,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagLOGCOLORSPACEW
    {
        public uint lcsSignature;
        public uint lcsVersion;
        public uint lcsSize;
        public int lcsCSType;
        public int lcsIntent;
        public tagICEXYZTRIPLE lcsEndpoints;
        public uint lcsGammaRed;
        public uint lcsGammaGreen;
        public uint lcsGammaBlue;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string lcsFilename;
    }
}
