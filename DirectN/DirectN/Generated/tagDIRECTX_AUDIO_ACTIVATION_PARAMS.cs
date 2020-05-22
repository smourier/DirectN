// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mmdeviceapi.h(159,9)
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
