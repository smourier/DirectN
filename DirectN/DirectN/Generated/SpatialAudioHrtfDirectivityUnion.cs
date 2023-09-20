// generated from <Windows SDK Path>\um\spatialaudiohrtf.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioHrtfDirectivityUnion
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public SpatialAudioHrtfDirectivityCone Cone { get => InteropRuntime.Get<SpatialAudioHrtfDirectivityCone>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<SpatialAudioHrtfDirectivityCone>(value, __bits, 0, 128); } }
        public SpatialAudioHrtfDirectivityCardioid Cardiod { get => InteropRuntime.Get<SpatialAudioHrtfDirectivityCardioid>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<SpatialAudioHrtfDirectivityCardioid>(value, __bits, 0, 96); } }
        public SpatialAudioHrtfDirectivity Omni { get => InteropRuntime.Get<SpatialAudioHrtfDirectivity>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<SpatialAudioHrtfDirectivity>(value, __bits, 0, 64); } }
    }
}
