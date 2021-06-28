// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mftransform.h(190,9)
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
