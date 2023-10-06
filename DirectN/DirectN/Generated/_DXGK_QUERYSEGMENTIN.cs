// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_QUERYSEGMENTIN
    {
        public long AgpApertureBase;
        public long AgpApertureSize;
        public _DXGK_SEGMENTFLAGS AgpFlags;
    }
}
