// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT QuerySegment { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT QueryProcessSegment { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT>(value, __bits, 0, 32); } }
        public _D3DKMT_MEMORY_SEGMENT_GROUP QueryProcessSegmentGroup { get => InteropRuntime.Get<_D3DKMT_MEMORY_SEGMENT_GROUP>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_MEMORY_SEGMENT_GROUP>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_NODE QueryNode { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_NODE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_NODE>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_NODE QueryProcessNode { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_NODE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_NODE>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_VIDPNSOURCE QueryVidPnSource { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_VIDPNSOURCE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_VIDPNSOURCE>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_VIDPNSOURCE QueryProcessVidPnSource { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_VIDPNSOURCE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_VIDPNSOURCE>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_PHYSICAL_ADAPTER QueryPhysAdapter { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_PHYSICAL_ADAPTER>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_PHYSICAL_ADAPTER>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_ADAPTER2 QueryAdapter2 { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_ADAPTER2>(__bits, 0, 16); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_ADAPTER2>(value, __bits, 0, 16); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT2 QuerySegment2 { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT2>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT2>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_ADAPTER2 QueryProcessAdapter2 { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_ADAPTER2>(__bits, 0, 16); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_ADAPTER2>(value, __bits, 0, 16); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT2 QueryProcessSegment2 { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT2>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT2>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_PROCESS_SEGMENT_GROUP2 QueryProcessSegmentGroup2 { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_PROCESS_SEGMENT_GROUP2>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_PROCESS_SEGMENT_GROUP2>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT_USAGE QuerySegmentUsage { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT_USAGE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT_USAGE>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT_GROUP_USAGE QuerySegmentGroupUsage { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT_GROUP_USAGE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT_GROUP_USAGE>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_NODE2 QueryNode2 { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_NODE2>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_NODE2>(value, __bits, 0, 32); } }
        public _D3DKMT_QUERYSTATISTICS_QUERY_NODE2 QueryProcessNode2 { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_QUERY_NODE2>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_QUERY_NODE2>(value, __bits, 0, 32); } }
    }
}
