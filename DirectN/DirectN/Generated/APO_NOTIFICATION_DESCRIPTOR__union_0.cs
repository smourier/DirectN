// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineextensionapo.h(515,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APO_NOTIFICATION_DESCRIPTOR__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public AUDIO_ENDPOINT_VOLUME_APO_NOTIFICATION_DESCRIPTOR audioEndpointVolume { get => InteropRuntime.Get<AUDIO_ENDPOINT_VOLUME_APO_NOTIFICATION_DESCRIPTOR>(__bits, 0, 0); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<AUDIO_ENDPOINT_VOLUME_APO_NOTIFICATION_DESCRIPTOR>(value, __bits, 0, 0); } }
        public AUDIO_ENDPOINT_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR audioEndpointPropertyChange { get => InteropRuntime.Get<AUDIO_ENDPOINT_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR>(__bits, 0, 0); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<AUDIO_ENDPOINT_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR>(value, __bits, 0, 0); } }
        public AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR audioSystemEffectsPropertyChange { get => InteropRuntime.Get<AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR>(value, __bits, 0, 128); } }
    }
}
