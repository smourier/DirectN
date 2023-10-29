using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MONITORINFO
    {
        public int cbSize;
        public tagRECT rcMonitor;
        public tagRECT rcWork;
        public int dwFlags;
    }
}
