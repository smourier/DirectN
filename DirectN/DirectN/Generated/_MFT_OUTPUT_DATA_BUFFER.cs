// generated from <Windows SDK Path>\um\mftransform.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFT_OUTPUT_DATA_BUFFER
    {
        public uint dwStreamID;
        public IntPtr pSample;
        public uint dwStatus;
        public IntPtr pEvents;
    }
}
