// generated from <Windows SDK Path>\um\audioclient.h
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
