// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_QUERYMMUSOUT
    {
        public IntPtr MmuDescriptors;
        public ushort DisplayMmuId;
        public ushort Reserved0;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] Reserved;
    }
}
