// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(472,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPMANAGER_PRESENTHISTORYTOKEN
    {
        public ulong hPrivateData;
        public ulong PresentAtQpc;
        public _D3DKMT_FLIPMANAGER_PRESENTHISTORYTOKEN__union_0 Flags;
    }
}
