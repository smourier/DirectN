// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PRESENTMULTIPLANEOVERLAYLIST
    {
        public uint LayerIndex;
        public bool Enabled;
        public IntPtr hDeviceSpecificAllocation;
        public _DXGK_PRESENTMULTIPLANEOVERLAYLIST__struct_0 __field_3;
        public long PhysicalAddress;
    }
}
