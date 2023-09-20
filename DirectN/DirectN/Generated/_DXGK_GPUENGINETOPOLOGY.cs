// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GPUENGINETOPOLOGY
    {
        public uint NbAsymetricProcessingNodes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public uint[] Reserved;
    }
}
