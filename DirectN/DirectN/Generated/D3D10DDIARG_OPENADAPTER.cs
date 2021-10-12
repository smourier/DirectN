// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(7610,9)
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
