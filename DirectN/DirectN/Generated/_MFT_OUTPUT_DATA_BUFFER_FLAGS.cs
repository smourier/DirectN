// generated from <Windows SDK Path>\um\mftransform.h
using System;

namespace DirectN
{
    [Flags]
    public enum _MFT_OUTPUT_DATA_BUFFER_FLAGS
    {
        MFT_OUTPUT_DATA_BUFFER_INCOMPLETE = 0x01000000,
        MFT_OUTPUT_DATA_BUFFER_FORMAT_CHANGE = 0x00000100,
        MFT_OUTPUT_DATA_BUFFER_STREAM_END = 0x00000200,
        MFT_OUTPUT_DATA_BUFFER_NO_SAMPLE = 0x00000300,
    }
}
