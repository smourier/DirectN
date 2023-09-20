// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
