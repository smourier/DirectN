// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDIMULTISAMPLEQUALITYLEVELSDATA
    {
        public _D3DDDIFORMAT Format;
        public bool Flip;
        public _D3DDDIMULTISAMPLE_TYPE MsType;
        public uint QualityLevels;
    }
}
