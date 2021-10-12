// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(7605,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct D3D12_DOWNLEVEL_DDI_UMDFILENAME
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string Filename;
    }
}
