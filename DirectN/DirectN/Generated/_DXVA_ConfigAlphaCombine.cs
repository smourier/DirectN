// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(614,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_ConfigAlphaCombine
    {
        public uint dwFunction;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] dwReservedBits;
        public byte bConfigBlendType;
        public byte bConfigPictureResizing;
        public byte bConfigOnlyUsePicDestRectArea;
        public byte bConfigGraphicResizing;
        public byte bConfigWholePlaneAlpha;
    }
}
