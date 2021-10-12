// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3753,5)
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
    }
}
