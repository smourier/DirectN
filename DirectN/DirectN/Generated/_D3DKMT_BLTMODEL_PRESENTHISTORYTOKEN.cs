// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_BLTMODEL_PRESENTHISTORYTOKEN
    {
        public ulong hLogicalSurface;
        public ulong hPhysicalSurface;
        public ulong EventId;
        public _D3DKMT_DIRTYREGIONS DirtyRegions;
    }
}
