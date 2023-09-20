// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GAMMA_1DLUT_CAP
    {
        public uint NumberOfLUTEntries;
        public _DKGK_GAMMA_DATA_CAP GammaDataCap;
    }
}
