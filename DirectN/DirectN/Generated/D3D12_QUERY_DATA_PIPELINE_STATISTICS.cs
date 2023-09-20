// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_QUERY_DATA_PIPELINE_STATISTICS
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
