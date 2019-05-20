// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxdiag.h(83,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXDIAG_INIT_PARAMS
    {
        public uint dwSize;
        public uint dwDxDiagHeaderVersion;
        public bool bAllowWHQLChecks;
        public IntPtr pReserved;
    }
}
