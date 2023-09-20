// generated from <Windows SDK Path>\um\mediaobj.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMO_OUTPUT_DATA_BUFFER
    {
        public IntPtr pBuffer;
        public uint dwStatus;
        public long rtTimestamp;
        public long rtTimelength;
    }
}
