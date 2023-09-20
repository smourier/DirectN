// generated from <Windows SDK Path>\um\dxdiag.h
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
