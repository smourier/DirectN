// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AudioClientProperties
    {
        public uint cbSize;
        public bool bIsOffload;
        public _AUDIO_STREAM_CATEGORY eCategory;
        public AUDCLNT_STREAMOPTIONS Options;
    }
}
