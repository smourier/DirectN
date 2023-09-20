// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_QUERYSEGMENTIN
    {
        public PHYSICAL_ADDRESS AgpApertureBase;
        public long AgpApertureSize;
        public _DXGK_SEGMENTFLAGS AgpFlags;
    }
}
