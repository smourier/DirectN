// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3942,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_RESULT
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 904)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION AdapterInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION>(__bits, 0, 7232); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION>(value, __bits, 0, 7232); } }
        public _D3DKMT_QUERYSTATISTICS_PHYSICAL_ADAPTER_INFORMATION PhysAdapterInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_PHYSICAL_ADAPTER_INFORMATION>(__bits, 0, 1792); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_PHYSICAL_ADAPTER_INFORMATION>(value, __bits, 0, 1792); } }
        public _D3DKMT_QUERYSTATISTICS_SEGMENT_INFORMATION SegmentInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_SEGMENT_INFORMATION>(__bits, 0, 1472); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_SEGMENT_INFORMATION>(value, __bits, 0, 1472); } }
        public _D3DKMT_QUERYSTATISTICS_NODE_INFORMATION NodeInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_NODE_INFORMATION>(__bits, 0, 4128); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_NODE_INFORMATION>(value, __bits, 0, 4128); } }
        public _D3DKMT_QUERYSTATISTICS_VIDPNSOURCE_INFORMATION VidPnSourceInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_VIDPNSOURCE_INFORMATION>(__bits, 0, 1792); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_VIDPNSOURCE_INFORMATION>(value, __bits, 0, 1792); } }
        public _D3DKMT_QUERYSTATISTICS_PROCESS_INFORMATION ProcessInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_PROCESS_INFORMATION>(__bits, 0, 1152); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_PROCESS_INFORMATION>(value, __bits, 0, 1152); } }
        public _D3DKMT_QUERYSTATISTICS_PROCESS_ADAPTER_INFORMATION ProcessAdapterInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_PROCESS_ADAPTER_INFORMATION>(__bits, 0, 2144); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_PROCESS_ADAPTER_INFORMATION>(value, __bits, 0, 2144); } }
        public _D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_INFORMATION ProcessSegmentInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_INFORMATION>(__bits, 0, 1280); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_INFORMATION>(value, __bits, 0, 1280); } }
        public _D3DKMT_QUERYSTATISTICS_PROCESS_NODE_INFORMATION ProcessNodeInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_PROCESS_NODE_INFORMATION>(__bits, 0, 1792); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_PROCESS_NODE_INFORMATION>(value, __bits, 0, 1792); } }
        public _D3DKMT_QUERYSTATISTICS_PROCESS_VIDPNSOURCE_INFORMATION ProcessVidPnSourceInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_PROCESS_VIDPNSOURCE_INFORMATION>(__bits, 0, 640); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_PROCESS_VIDPNSOURCE_INFORMATION>(value, __bits, 0, 640); } }
        public _D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_GROUP_INFORMATION ProcessSegmentGroupInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_GROUP_INFORMATION>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_GROUP_INFORMATION>(value, __bits, 0, 512); } }
        public _D3DKMT_QUERYSTATISTICS_MEMORY_USAGE SegmentUsageInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_MEMORY_USAGE>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_MEMORY_USAGE>(value, __bits, 0, 320); } }
        public _D3DKMT_QUERYSTATISTICS_MEMORY_USAGE SegmentGroupUsageInformation { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_MEMORY_USAGE>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[904]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_MEMORY_USAGE>(value, __bits, 0, 320); } }
    }
}
