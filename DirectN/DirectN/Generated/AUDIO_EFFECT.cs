// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioclient.h(1855,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_EFFECT
    {
        public Guid id;
        public bool canSetState;
        public AUDIO_EFFECT_STATE state;
    }
}
