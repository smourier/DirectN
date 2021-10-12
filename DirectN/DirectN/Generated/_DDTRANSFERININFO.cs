// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxmini.h(275,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDTRANSFERININFO
    {
        public IntPtr lpSurfaceData;
        public uint dwStartLine;
        public uint dwEndLine;
        public IntPtr dwTransferID;
        public uint dwTransferFlags;
        public IntPtr lpDestMDL;
    }
}
