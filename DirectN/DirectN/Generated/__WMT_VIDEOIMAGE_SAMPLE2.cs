// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(1693,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __WMT_VIDEOIMAGE_SAMPLE2
    {
        public uint dwMagic;
        public uint dwStructSize;
        public uint dwControlFlags;
        public uint dwViewportWidth;
        public uint dwViewportHeight;
        public uint dwCurrImageWidth;
        public uint dwCurrImageHeight;
        public float fCurrRegionX0;
        public float fCurrRegionY0;
        public float fCurrRegionWidth;
        public float fCurrRegionHeight;
        public float fCurrBlendCoef;
        public uint dwPrevImageWidth;
        public uint dwPrevImageHeight;
        public float fPrevRegionX0;
        public float fPrevRegionY0;
        public float fPrevRegionWidth;
        public float fPrevRegionHeight;
        public float fPrevBlendCoef;
        public uint dwEffectType;
        public uint dwNumEffectParas;
        public float fEffectPara0;
        public float fEffectPara1;
        public float fEffectPara2;
        public float fEffectPara3;
        public float fEffectPara4;
        public bool bKeepPrevImage;
    }
}
