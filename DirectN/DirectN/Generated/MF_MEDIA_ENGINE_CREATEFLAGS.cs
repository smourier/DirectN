﻿// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;

namespace DirectN
{
    [Flags]
    public enum MF_MEDIA_ENGINE_CREATEFLAGS
    {
        MF_MEDIA_ENGINE_AUDIOONLY = 0x00000001,
        MF_MEDIA_ENGINE_WAITFORSTABLE_STATE = 0x00000002,
        MF_MEDIA_ENGINE_FORCEMUTE = 0x00000004,
        MF_MEDIA_ENGINE_REAL_TIME_MODE = 0x00000008,
        MF_MEDIA_ENGINE_DISABLE_LOCAL_PLUGINS = 0x00000010,
        MF_MEDIA_ENGINE_CREATEFLAGS_MASK = 0x0000001F,
    }
}
