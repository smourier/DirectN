// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\mmreg.h(3577,9)
using System;
using System.Runtime.InteropServices;
using BITMAPINFOHEADER = DirectN.tagBITMAPINFOHEADER;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct tagEXBMINFOHEADER
    {
        public BITMAPINFOHEADER bmi;
        public uint biExtDataOffset;
    }
}
