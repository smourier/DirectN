// generated from <Windows SDK Path>\um\dxmini.h
using System;
using System.Runtime.InteropServices;
using PDX_IRQCALLBACK = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDENABLEIRQINFO
    {
        public uint dwIRQSources;
        public uint dwLine;
        public IntPtr IRQCallback;
        public IntPtr lpIRQData;
    }
}
