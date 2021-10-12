// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(682,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_BlendCombination
    {
        public ushort wPictureSourceIndex;
        public ushort wBlendedDestinationIndex;
        public tagRECT PictureSourceRect16thPel;
        public tagRECT PictureDestinationRect;
        public tagRECT GraphicSourceRect;
        public tagRECT GraphicDestinationRect;
        public ushort wBlendDelay;
        public byte bBlendOn;
        public byte bWholePlaneAlpha;
        public _DXVA_AYUVsample2 OutsideYUVcolor;
    }
}
