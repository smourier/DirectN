// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wingdi.h(4976,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCOLORADJUSTMENT
    {
        public ushort caSize;
        public ushort caFlags;
        public ushort caIlluminantIndex;
        public ushort caRedGamma;
        public ushort caGreenGamma;
        public ushort caBlueGamma;
        public ushort caReferenceBlack;
        public ushort caReferenceWhite;
        public short caContrast;
        public short caBrightness;
        public short caColorfulness;
        public short caRedGreenTint;
    }
}
