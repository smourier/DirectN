// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using D3DKMDT_HVIDPN = DirectN.D3DKMDT_HVIDPN__;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_ENUMVIDPNCOFUNCMODALITY
    {
        public IntPtr hConstrainingVidPn;
        public _D3DKMDT_ENUMCOFUNCMODALITY_PIVOT_TYPE EnumPivotType;
        public _DXGK_ENUM_PIVOT EnumPivot;
    }
}
