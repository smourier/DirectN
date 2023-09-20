// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DKGK_GAMMA_DATA_CAP
    {
        public _DXGK_GAMMA_DATA_TYPE DataType;
        public _DKGK_GAMMA_DATA_CAP__union_0 __union_1;
        public float NumericRangeMin;
        public float NumericRangeMax;
    }
}
