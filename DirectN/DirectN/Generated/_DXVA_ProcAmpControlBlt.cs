// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_ProcAmpControlBlt
    {
        public uint Size;
        public tagRECT DstRect;
        public tagRECT SrcRect;
        public float Alpha;
        public float Brightness;
        public float Contrast;
        public float Hue;
        public float Saturation;
    }
}
