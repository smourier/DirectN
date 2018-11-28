using System;

namespace DirectN
{
    [Flags]
    public enum MFT_PROCESS_OUTPUT_FLAGS
    {
        MFT_PROCESS_OUTPUT_NONE = 0x0,
        MFT_PROCESS_OUTPUT_DISCARD_WHEN_NO_BUFFER = 0x1,
        MFT_PROCESS_OUTPUT_REGENERATE_LAST_OUTPUT = 0x2
    }
}
