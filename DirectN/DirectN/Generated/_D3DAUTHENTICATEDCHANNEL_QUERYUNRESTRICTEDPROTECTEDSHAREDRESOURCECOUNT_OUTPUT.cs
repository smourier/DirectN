// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3d9types.h(2212,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERYUNRESTRICTEDPROTECTEDSHAREDRESOURCECOUNT_OUTPUT
    {
        public _D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;
        public uint NumUnrestrictedProtectedSharedResources;
    }
}
