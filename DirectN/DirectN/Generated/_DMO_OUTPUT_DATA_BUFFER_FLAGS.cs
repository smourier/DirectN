// generated from <Windows SDK Path>\um\mediaobj.h
using System;

namespace DirectN
{
    [Flags]
    public enum _DMO_OUTPUT_DATA_BUFFER_FLAGS
    {
        DMO_OUTPUT_DATA_BUFFERF_SYNCPOINT = 0x00000001,
        DMO_OUTPUT_DATA_BUFFERF_TIME = 0x00000002,
        DMO_OUTPUT_DATA_BUFFERF_TIMELENGTH = 0x00000004,
        DMO_OUTPUT_DATA_BUFFERF_DISCONTINUITY = 0x00000008,
        DMO_OUTPUT_DATA_BUFFERF_INCOMPLETE = 0x01000000,
    }
}
