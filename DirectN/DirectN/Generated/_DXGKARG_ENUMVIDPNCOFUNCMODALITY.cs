// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5511,9)
using System;
using System.Runtime.InteropServices;

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
