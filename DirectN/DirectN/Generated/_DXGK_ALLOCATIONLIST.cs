// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(71,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONLIST
    {
        public IntPtr hDeviceSpecificAllocation;
        public _DXGK_ALLOCATIONLIST__struct_0 __field_1;
        public _DXGK_ALLOCATIONLIST__union_1 __union_2;
    }
}
