// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1916,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_VIDMMCAPS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint OutOfOrderLock { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint DedicatedPagingEngine { get => InteropRuntime.GetUInt32(__bits, 1, 1); set => InteropRuntime.SetUInt32(value, __bits, 1, 1); }
        public uint PagingEngineCanSwizzle { get => InteropRuntime.GetUInt32(__bits, 2, 1); set => InteropRuntime.SetUInt32(value, __bits, 2, 1); }
        public uint SectionBackedPrimary { get => InteropRuntime.GetUInt32(__bits, 3, 1); set => InteropRuntime.SetUInt32(value, __bits, 3, 1); }
        public uint CrossAdapterResource { get => InteropRuntime.GetUInt32(__bits, 4, 1); set => InteropRuntime.SetUInt32(value, __bits, 4, 1); }
        public uint VirtualAddressingSupported { get => InteropRuntime.GetUInt32(__bits, 5, 1); set => InteropRuntime.SetUInt32(value, __bits, 5, 1); }
        public uint GpuMmuSupported { get => InteropRuntime.GetUInt32(__bits, 6, 1); set => InteropRuntime.SetUInt32(value, __bits, 6, 1); }
        public uint IoMmuSupported { get => InteropRuntime.GetUInt32(__bits, 7, 1); set => InteropRuntime.SetUInt32(value, __bits, 7, 1); }
        public uint ReplicateGdiContent { get => InteropRuntime.GetUInt32(__bits, 8, 1); set => InteropRuntime.SetUInt32(value, __bits, 8, 1); }
        public uint NonCpuVisiblePrimary { get => InteropRuntime.GetUInt32(__bits, 9, 1); set => InteropRuntime.SetUInt32(value, __bits, 9, 1); }
        public uint ParavirtualizationSupported { get => InteropRuntime.GetUInt32(__bits, 10, 1); set => InteropRuntime.SetUInt32(value, __bits, 10, 1); }
        public uint IoMmuSecureModeSupported { get => InteropRuntime.GetUInt32(__bits, 11, 1); set => InteropRuntime.SetUInt32(value, __bits, 11, 1); }
        public uint DisableSelfRefreshVRAMInS3 { get => InteropRuntime.GetUInt32(__bits, 12, 1); set => InteropRuntime.SetUInt32(value, __bits, 12, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 13, 19); set => InteropRuntime.SetUInt32(value, __bits, 13, 19); }
    }
}
