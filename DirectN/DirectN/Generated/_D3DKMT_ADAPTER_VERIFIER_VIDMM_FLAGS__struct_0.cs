// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2817,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ADAPTER_VERIFIER_VIDMM_FLAGS__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint AlwaysRepatch { get => InteropRuntime.GetUInt32(__bits, 0, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint FailSharedPrimary { get => InteropRuntime.GetUInt32(__bits, 1, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        public uint FailProbeAndLock { get => InteropRuntime.GetUInt32(__bits, 2, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 1); } }
        public uint AlwaysDiscardOffer { get => InteropRuntime.GetUInt32(__bits, 3, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 3, 1); } }
        public uint NeverDiscardOffer { get => InteropRuntime.GetUInt32(__bits, 4, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
        public uint ForceComplexLock { get => InteropRuntime.GetUInt32(__bits, 5, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 5, 1); } }
        public uint NeverPrepatch { get => InteropRuntime.GetUInt32(__bits, 6, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 6, 1); } }
        public uint ExpectPreparationFailure { get => InteropRuntime.GetUInt32(__bits, 7, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 7, 1); } }
        public uint TakeSplitPoint { get => InteropRuntime.GetUInt32(__bits, 8, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 1); } }
        public uint FailAcquireSwizzlingRange { get => InteropRuntime.GetUInt32(__bits, 9, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 9, 1); } }
        public uint PagingPathLockSubrange { get => InteropRuntime.GetUInt32(__bits, 10, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 10, 1); } }
        public uint PagingPathLockMinrange { get => InteropRuntime.GetUInt32(__bits, 11, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 11, 1); } }
        public uint FailVaRotation { get => InteropRuntime.GetUInt32(__bits, 12, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 12, 1); } }
        public uint NoDemotion { get => InteropRuntime.GetUInt32(__bits, 13, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 13, 1); } }
        public uint FailDefragPass { get => InteropRuntime.GetUInt32(__bits, 14, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 14, 1); } }
        public uint AlwaysProcessOfferList { get => InteropRuntime.GetUInt32(__bits, 15, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 15, 1); } }
        public uint AlwaysDecommitOffer { get => InteropRuntime.GetUInt32(__bits, 16, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 1); } }
        public uint NeverMoveDefrag { get => InteropRuntime.GetUInt32(__bits, 17, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 17, 1); } }
        public uint AlwaysRelocateDisplayableResources { get => InteropRuntime.GetUInt32(__bits, 18, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 18, 1); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 19, 13); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 19, 13); } }
    }
}
