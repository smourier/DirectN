// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(537,9)
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
