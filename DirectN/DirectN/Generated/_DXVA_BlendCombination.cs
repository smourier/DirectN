// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(676,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_BlendCombination
    {
        public ushort wPictureSourceIndex;
        public ushort wBlendedDestinationIndex;
        public RECT PictureSourceRect16thPel;
        public RECT PictureDestinationRect;
        public RECT GraphicSourceRect;
        public RECT GraphicDestinationRect;
        public ushort wBlendDelay;
        public byte bBlendOn;
        public byte bWholePlaneAlpha;
        public _DXVA_AYUVsample2 OutsideYUVcolor;
    }
}
