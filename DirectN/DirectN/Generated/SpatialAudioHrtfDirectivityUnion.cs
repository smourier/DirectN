// generated from <Windows SDK Path>\um\spatialaudiohrtf.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioHrtfDirectivityUnion
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public SpatialAudioHrtfDirectivityCone Cone {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<SpatialAudioHrtfDirectivityCone>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<SpatialAudioHrtfDirectivityCone>(value, __bits, 0, 128); } }
        public SpatialAudioHrtfDirectivityCardioid Cardiod {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<SpatialAudioHrtfDirectivityCardioid>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<SpatialAudioHrtfDirectivityCardioid>(value, __bits, 0, 96); } }
        public SpatialAudioHrtfDirectivity Omni {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<SpatialAudioHrtfDirectivity>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<SpatialAudioHrtfDirectivity>(value, __bits, 0, 64); } }
    }
}
