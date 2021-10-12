// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(7818,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RECOMMENDMONITORMODES
    {
        public uint VideoPresentTargetId;
        public IntPtr hMonitorSourceModeSet;
        public IntPtr pMonitorSourceModeSetInterface;
    }
}
