// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4333,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_0 Transfer { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_0>(__bits, 0, 1536); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_0>(value, __bits, 0, 1536); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_1 Fill { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_1>(__bits, 0, 384); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_1>(value, __bits, 0, 384); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_2 DiscardContent { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_2>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_2>(value, __bits, 0, 192); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_3 ReadPhysical { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_3>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_3>(value, __bits, 0, 128); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_4 WritePhysical { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_4>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_4>(value, __bits, 0, 128); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_5 MapApertureSegment { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_5>(__bits, 0, 448); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_5>(value, __bits, 0, 448); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_6 UnmapApertureSegment { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_6>(__bits, 0, 384); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_6>(value, __bits, 0, 384); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_7 SpecialLockTransfer { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_7>(__bits, 0, 1568); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_7>(value, __bits, 0, 1568); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_8 InitContextResource { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_8>(__bits, 0, 832); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_8>(value, __bits, 0, 832); } }
        public _DXGK_BUILDPAGINGBUFFER_TRANSFERVIRTUAL TransferVirtual { get => InteropRuntime.Get<_DXGK_BUILDPAGINGBUFFER_TRANSFERVIRTUAL>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGK_BUILDPAGINGBUFFER_TRANSFERVIRTUAL>(value, __bits, 0, 512); } }
        public _DXGK_BUILDPAGINGBUFFER_FILLVIRTUAL FillVirtual { get => InteropRuntime.Get<_DXGK_BUILDPAGINGBUFFER_FILLVIRTUAL>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGK_BUILDPAGINGBUFFER_FILLVIRTUAL>(value, __bits, 0, 320); } }
        public _DXGK_BUILDPAGINGBUFFER_UPDATEPAGETABLE UpdatePageTable { get => InteropRuntime.Get<_DXGK_BUILDPAGINGBUFFER_UPDATEPAGETABLE>(__bits, 0, 1024); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGK_BUILDPAGINGBUFFER_UPDATEPAGETABLE>(value, __bits, 0, 1024); } }
        public _DXGK_BUILDPAGINGBUFFER_FLUSHTLB FlushTlb { get => InteropRuntime.Get<_DXGK_BUILDPAGINGBUFFER_FLUSHTLB>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGK_BUILDPAGINGBUFFER_FLUSHTLB>(value, __bits, 0, 320); } }
        public _DXGK_BUILDPAGINGBUFFER_COPYPAGETABLEENTRIES CopyPageTableEntries { get => InteropRuntime.Get<_DXGK_BUILDPAGINGBUFFER_COPYPAGETABLEENTRIES>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGK_BUILDPAGINGBUFFER_COPYPAGETABLEENTRIES>(value, __bits, 0, 512); } }
        public _DXGK_BUILDPAGINGBUFFER_UPDATECONTEXTALLOCATION UpdateContextAllocation { get => InteropRuntime.Get<_DXGK_BUILDPAGINGBUFFER_UPDATECONTEXTALLOCATION>(__bits, 0, 224); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGK_BUILDPAGINGBUFFER_UPDATECONTEXTALLOCATION>(value, __bits, 0, 224); } }
        public _DXGK_BUILDPAGINGBUFFER_NOTIFYRESIDENCY NotifyResidency { get => InteropRuntime.Get<_DXGK_BUILDPAGINGBUFFER_NOTIFYRESIDENCY>(__bits, 0, 224); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGK_BUILDPAGINGBUFFER_NOTIFYRESIDENCY>(value, __bits, 0, 224); } }
        public _DXGK_BUILDPAGINGBUFFER_SIGNALMONITOREDFENCE SignalMonitoredFence { get => InteropRuntime.Get<_DXGK_BUILDPAGINGBUFFER_SIGNALMONITOREDFENCE>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGK_BUILDPAGINGBUFFER_SIGNALMONITOREDFENCE>(value, __bits, 0, 128); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_9 MapApertureSegment2 { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_9>(__bits, 0, 576); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_9>(value, __bits, 0, 576); } }
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_10 Reserved { get => InteropRuntime.Get<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_10>(__bits, 0, 2048); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_DXGKARG_BUILDPAGINGBUFFER__union_0__struct_10>(value, __bits, 0, 2048); } }
    }
}
