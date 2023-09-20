// generated from <Windows SDK Path>\um\dxva.h
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
