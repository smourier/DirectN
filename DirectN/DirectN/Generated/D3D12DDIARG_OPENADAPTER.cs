// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(2569,9)
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
