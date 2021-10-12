// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(12587,1)
using System;

namespace DirectN
{
    [Flags]
    public enum tagTVAudioMode
    {
        AMTVAUDIO_MODE_MONO = 0x00000001,
        AMTVAUDIO_MODE_STEREO = 0x00000002,
        AMTVAUDIO_MODE_LANG_A = 0x00000010,
        AMTVAUDIO_MODE_LANG_B = 0x00000020,
        AMTVAUDIO_MODE_LANG_C = 0x00000040,
        AMTVAUDIO_PRESET_STEREO = 0x00000200,
        AMTVAUDIO_PRESET_LANG_A = 0x00001000,
        AMTVAUDIO_PRESET_LANG_B = 0x00002000,
        AMTVAUDIO_PRESET_LANG_C = 0x00004000,
    }
}
