// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_MICROPHONE_BOOST_NOTIFICATION
    {
        public IntPtr endpoint;
        public Guid eventContext;
        public bool microphoneBoostEnabled;
        public float levelInDb;
        public float levelMinInDb;
        public float levelMaxInDb;
        public float levelStepInDb;
        public bool muteSupported;
        public bool mute;
    }
}
