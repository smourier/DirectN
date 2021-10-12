// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(1079,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_DDI_QUERY_DATA_PIPELINE_STATISTICS
    {
        public ulong IAVertices;
        public ulong IAPrimitives;
        public ulong VSInvocations;
        public ulong GSInvocations;
        public ulong GSPrimitives;
        public ulong CInvocations;
        public ulong CPrimitives;
        public ulong PSInvocations;
        public ulong HSInvocations;
        public ulong DSInvocations;
        public ulong CSInvocations;
    }
}
