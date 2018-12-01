// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(563,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDCAPS_DX6
    {
        public uint dwSize;
        public uint dwCaps;
        public uint dwCaps2;
        public uint dwCKeyCaps;
        public uint dwFXCaps;
        public uint dwFXAlphaCaps;
        public uint dwPalCaps;
        public uint dwSVCaps;
        public uint dwAlphaBltConstBitDepths;
        public uint dwAlphaBltPixelBitDepths;
        public uint dwAlphaBltSurfaceBitDepths;
        public uint dwAlphaOverlayConstBitDepths;
        public uint dwAlphaOverlayPixelBitDepths;
        public uint dwAlphaOverlaySurfaceBitDepths;
        public uint dwZBufferBitDepths;
        public uint dwVidMemTotal;
        public uint dwVidMemFree;
        public uint dwMaxVisibleOverlays;
        public uint dwCurrVisibleOverlays;
        public uint dwNumFourCCCodes;
        public uint dwAlignBoundarySrc;
        public uint dwAlignSizeSrc;
        public uint dwAlignBoundaryDest;
        public uint dwAlignSizeDest;
        public uint dwAlignStrideAlign;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] dwRops;
        public _DDSCAPS ddsOldCaps;
        public uint dwMinOverlayStretch;
        public uint dwMaxOverlayStretch;
        public uint dwMinLiveVideoStretch;
        public uint dwMaxLiveVideoStretch;
        public uint dwMinHwCodecStretch;
        public uint dwMaxHwCodecStretch;
        public uint dwReserved1;
        public uint dwReserved2;
        public uint dwReserved3;
        public uint dwSVBCaps;
        public uint dwSVBCKeyCaps;
        public uint dwSVBFXCaps;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] dwSVBRops;
        public uint dwVSBCaps;
        public uint dwVSBCKeyCaps;
        public uint dwVSBFXCaps;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] dwVSBRops;
        public uint dwSSBCaps;
        public uint dwSSBCKeyCaps;
        public uint dwSSBFXCaps;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] dwSSBRops;
        public uint dwMaxVideoPorts;
        public uint dwCurrVideoPorts;
        public uint dwSVBCaps2;
        public uint dwNLVBCaps;
        public uint dwNLVBCaps2;
        public uint dwNLVBCKeyCaps;
        public uint dwNLVBFXCaps;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] dwNLVBRops;
        public _DDSCAPS2 ddsCaps;
    }
}
