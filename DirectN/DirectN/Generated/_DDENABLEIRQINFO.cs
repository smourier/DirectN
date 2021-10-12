// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxmini.h(180,9)
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
