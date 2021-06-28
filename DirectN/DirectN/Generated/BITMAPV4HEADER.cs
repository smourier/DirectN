// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(834,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct BITMAPV4HEADER
    {
        public uint bV4Size;
        public int bV4Width;
        public int bV4Height;
        public ushort bV4Planes;
        public ushort bV4BitCount;
        public uint bV4V4Compression;
        public uint bV4SizeImage;
        public int bV4XPelsPerMeter;
        public int bV4YPelsPerMeter;
        public uint bV4ClrUsed;
        public uint bV4ClrImportant;
        public uint bV4RedMask;
        public uint bV4GreenMask;
        public uint bV4BlueMask;
        public uint bV4AlphaMask;
        public uint bV4CSType;
        public tagICEXYZTRIPLE bV4Endpoints;
        public uint bV4GammaRed;
        public uint bV4GammaGreen;
        public uint bV4GammaBlue;
    }
}
