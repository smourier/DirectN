// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineextensionapo.h(488,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APO_NOTIFICATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION audioEndpointVolumeChange { get => InteropRuntime.Get<AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION>(value, __bits, 0, 64); } }
        public AUDIO_ENDPOINT_PROPERTY_CHANGE_NOTIFICATION audioEndpointPropertyChange { get => InteropRuntime.Get<AUDIO_ENDPOINT_PROPERTY_CHANGE_NOTIFICATION>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<AUDIO_ENDPOINT_PROPERTY_CHANGE_NOTIFICATION>(value, __bits, 0, 64); } }
        public AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_NOTIFICATION audioSystemEffectsPropertyChange { get => InteropRuntime.Get<AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_NOTIFICATION>(__bits, 0, 256); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_NOTIFICATION>(value, __bits, 0, 256); } }
    }
}
