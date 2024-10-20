// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APO_NOTIFICATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION audioEndpointVolumeChange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION>(value, __bits, 0, 128); } }
        public AUDIO_ENDPOINT_PROPERTY_CHANGE_NOTIFICATION audioEndpointPropertyChange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_ENDPOINT_PROPERTY_CHANGE_NOTIFICATION>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<AUDIO_ENDPOINT_PROPERTY_CHANGE_NOTIFICATION>(value, __bits, 0, 320); } }
        public AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_NOTIFICATION audioSystemEffectsPropertyChange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_NOTIFICATION>(__bits, 0, 512);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_NOTIFICATION>(value, __bits, 0, 512); } }
        public AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION2 audioEndpointVolumeChange2 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION2>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION2>(value, __bits, 0, 128); } }
        public DEVICE_ORIENTATION_TYPE deviceOrientation {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DEVICE_ORIENTATION_TYPE>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<DEVICE_ORIENTATION_TYPE>(value, __bits, 0, 32); } }
        public AUDIO_MICROPHONE_BOOST_NOTIFICATION audioMicrophoneBoostChange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_MICROPHONE_BOOST_NOTIFICATION>(__bits, 0, 448);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<AUDIO_MICROPHONE_BOOST_NOTIFICATION>(value, __bits, 0, 448); } }
        public AUDIO_ENVIRONMENT_STATE_CHANGE_NOTIFICATION audioEnvironmentChange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_ENVIRONMENT_STATE_CHANGE_NOTIFICATION>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<AUDIO_ENVIRONMENT_STATE_CHANGE_NOTIFICATION>(value, __bits, 0, 256); } }
    }
}
