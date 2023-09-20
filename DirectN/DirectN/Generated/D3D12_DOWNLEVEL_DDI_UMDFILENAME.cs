// generated from <Windows SDK Path>\um\d3d10umddi.h
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
