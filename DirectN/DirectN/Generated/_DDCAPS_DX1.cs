// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDCAPS_DX1
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
        public _DDSCAPS ddsCaps;
        public uint dwMinOverlayStretch;
        public uint dwMaxOverlayStretch;
        public uint dwMinLiveVideoStretch;
        public uint dwMaxLiveVideoStretch;
        public uint dwMinHwCodecStretch;
        public uint dwMaxHwCodecStretch;
        public uint dwReserved1;
        public uint dwReserved2;
        public uint dwReserved3;
    }
}
