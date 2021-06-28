// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(390,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicResample
    {
        public ushort wPicResampleSourcePicIndex;
        public ushort wPicResampleDestPicIndex;
        public ushort wPicResampleRcontrol;
        public byte bPicResampleExtrapWidth;
        public byte bPicResampleExtrapHeight;
        public uint dwPicResampleSourceWidth;
        public uint dwPicResampleSourceHeight;
        public uint dwPicResampleDestWidth;
        public uint dwPicResampleDestHeight;
        public uint dwPicResampleFullDestWidth;
        public uint dwPicResampleFullDestHeight;
    }
}
