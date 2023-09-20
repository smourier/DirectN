// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_OPENADAPTER
    {
        public D3D10DDI_HRTADAPTER hRTAdapter;
        public D3D10DDI_HADAPTER hAdapter;
        public uint Interface;
        public uint Version;
        public IntPtr pAdapterCallbacks;
        public D3D10DDIARG_OPENADAPTER__union_0 __union_5;
    }
}
