// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(214,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PRESENTMULTIPLANEOVERLAYLIST
    {
        public uint LayerIndex;
        public bool Enabled;
        public IntPtr hDeviceSpecificAllocation;
        public _DXGK_PRESENTMULTIPLANEOVERLAYLIST__struct_0 __field_3;
        public PHYSICAL_ADDRESS PhysicalAddress;
    }
}
