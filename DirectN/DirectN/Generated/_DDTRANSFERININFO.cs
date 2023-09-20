// generated from <Windows SDK Path>\um\dxmini.h
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
