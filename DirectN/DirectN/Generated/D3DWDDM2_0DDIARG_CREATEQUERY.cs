// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(5353,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDIARG_CREATEQUERY
    {
        public D3D10DDI_QUERY Query;
        public uint MiscFlags;
        public uint ContextType;
    }
}
