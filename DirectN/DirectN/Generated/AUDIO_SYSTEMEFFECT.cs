// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_SYSTEMEFFECT
    {
        public Guid id;
        public bool canSetState;
        public AUDIO_SYSTEMEFFECT_STATE state;
    }
}
