// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2600,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_FILTER_RANGE_DATA
    {
        public int Minimum;
        public int Maximum;
        public int Default;
        public float Multiplier;
    }
}
