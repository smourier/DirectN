// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_OPENADAPTER
    {
        public D3D10DDI_HRTADAPTER hRTAdapter;
        public D3D10DDI_HADAPTER hAdapter;
        public IntPtr pAdapterCallbacks;
        public IntPtr pAdapterFuncs;
    }
}
