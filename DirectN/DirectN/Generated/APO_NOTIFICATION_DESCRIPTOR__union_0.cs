// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APO_NOTIFICATION_DESCRIPTOR__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public AUDIO_ENDPOINT_VOLUME_APO_NOTIFICATION_DESCRIPTOR audioEndpointVolume {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_ENDPOINT_VOLUME_APO_NOTIFICATION_DESCRIPTOR>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<AUDIO_ENDPOINT_VOLUME_APO_NOTIFICATION_DESCRIPTOR>(value, __bits, 0, 64); } }
        public AUDIO_ENDPOINT_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR audioEndpointPropertyChange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_ENDPOINT_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<AUDIO_ENDPOINT_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR>(value, __bits, 0, 64); } }
        public AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR audioSystemEffectsPropertyChange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR>(value, __bits, 0, 192); } }
        public AUDIO_MICROPHONE_BOOST_APO_NOTIFICATION_DESCRIPTOR audioMicrophoneBoost {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<AUDIO_MICROPHONE_BOOST_APO_NOTIFICATION_DESCRIPTOR>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<AUDIO_MICROPHONE_BOOST_APO_NOTIFICATION_DESCRIPTOR>(value, __bits, 0, 64); } }
    }
}
