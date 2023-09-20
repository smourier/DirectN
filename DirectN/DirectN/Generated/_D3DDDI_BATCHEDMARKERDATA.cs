// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_BATCHEDMARKERDATA
    {
        public IntPtr hRTCommandListHandle;
        public uint FirstAPISequenceNumberHigh;
        public uint CompletedAPISequenceNumberLowSize;
        public IntPtr pCompletedAPISequenceNumberLow;
    }
}
