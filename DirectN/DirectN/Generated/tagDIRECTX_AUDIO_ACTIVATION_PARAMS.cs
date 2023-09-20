// generated from <Windows SDK Path>\um\mmdeviceapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDIRECTX_AUDIO_ACTIVATION_PARAMS
    {
        public uint cbDirectXAudioActivationParams;
        public Guid guidAudioSession;
        public uint dwAudioStreamFlags;
    }
}
