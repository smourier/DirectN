// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MF_TRANSCODE_SINK_INFO
    {
        public uint dwVideoStreamID;
        public IntPtr pVideoMediaType;
        public uint dwAudioStreamID;
        public IntPtr pAudioMediaType;
    }
}
