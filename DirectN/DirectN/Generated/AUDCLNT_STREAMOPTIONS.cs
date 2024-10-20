// generated from <Windows SDK Path>\um\audioclient.h
using System;

namespace DirectN
{
    [Flags]
    public enum AUDCLNT_STREAMOPTIONS
    {
        AUDCLNT_STREAMOPTIONS_NONE = 0x00000000,
        AUDCLNT_STREAMOPTIONS_RAW = 0x00000001,
        AUDCLNT_STREAMOPTIONS_MATCH_FORMAT = 0x00000002,
        AUDCLNT_STREAMOPTIONS_AMBISONICS = 0x00000004,
        AUDCLNT_STREAMOPTIONS_POST_VOLUME_LOOPBACK = 0x00000008,
    }
}
