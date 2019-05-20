// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1959,9)
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
