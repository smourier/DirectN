// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(405,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKENFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Video { get => InteropRuntime.GetUInt32(__bits, 0, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 1); } }
        public uint RestrictedContent { get => InteropRuntime.GetUInt32(__bits, 1, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 1, 1); } }
        public uint ClipToView { get => InteropRuntime.GetUInt32(__bits, 2, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 2, 1); } }
        public uint StereoPreferRight { get => InteropRuntime.GetUInt32(__bits, 3, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 3, 1); } }
        public uint TemporaryMono { get => InteropRuntime.GetUInt32(__bits, 4, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 4, 1); } }
        public uint FlipRestart { get => InteropRuntime.GetUInt32(__bits, 5, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 5, 1); } }
        public uint HDRMetaDataChanged { get => InteropRuntime.GetUInt32(__bits, 6, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 6, 1); } }
        public uint AlphaMode { get => InteropRuntime.GetUInt32(__bits, 7, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 7, 2); } }
        public uint SignalLimitOnTokenCompletion { get => InteropRuntime.GetUInt32(__bits, 9, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 9, 1); } }
        public uint YCbCrFlags { get => InteropRuntime.GetUInt32(__bits, 10, 3); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 10, 3); } }
        public uint IndependentFlip { get => InteropRuntime.GetUInt32(__bits, 13, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 13, 1); } }
        public _D3DKMT_FLIPMODEL_INDEPENDENT_FLIP_STAGE IndependentFlipStage { get => InteropRuntime.Get<_D3DKMT_FLIPMODEL_INDEPENDENT_FLIP_STAGE>(__bits, 14, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_FLIPMODEL_INDEPENDENT_FLIP_STAGE>(value, __bits, 14, 2); } }
        public uint IndependentFlipReleaseCount { get => InteropRuntime.GetUInt32(__bits, 16, 2); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 2); } }
        public uint IndependentFlipForceNotifyDwm { get => InteropRuntime.GetUInt32(__bits, 18, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 18, 1); } }
        public uint UseCustomDuration { get => InteropRuntime.GetUInt32(__bits, 19, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 19, 1); } }
        public uint IndependentFlipRequestDwmConfirm { get => InteropRuntime.GetUInt32(__bits, 20, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 20, 1); } }
        public uint IndependentFlipCandidate { get => InteropRuntime.GetUInt32(__bits, 21, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 21, 1); } }
        public uint IndependentFlipCheckNeeded { get => InteropRuntime.GetUInt32(__bits, 22, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 22, 1); } }
        public uint IndependentFlipTrueImmediate { get => InteropRuntime.GetUInt32(__bits, 23, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 23, 1); } }
        public uint IndependentFlipRequestDwmExit { get => InteropRuntime.GetUInt32(__bits, 24, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 24, 1); } }
        public uint CompSurfaceNotifiedEarly { get => InteropRuntime.GetUInt32(__bits, 25, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 25, 1); } }
        public uint IndependentFlipDoNotFlip { get => InteropRuntime.GetUInt32(__bits, 26, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 26, 1); } }
        public uint RequirePairedToken { get => InteropRuntime.GetUInt32(__bits, 27, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 27, 1); } }
        public uint VariableRefreshOverrideEligible { get => InteropRuntime.GetUInt32(__bits, 28, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 28, 1); } }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 29, 3); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 29, 3); } }
    }
}
