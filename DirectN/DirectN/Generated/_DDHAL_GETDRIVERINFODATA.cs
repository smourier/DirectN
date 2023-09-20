// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETDRIVERINFODATA
    {
        public uint dwSize;
        public uint dwFlags;
        public Guid guidInfo;
        public uint dwExpectedSize;
        public IntPtr lpvData;
        public uint dwActualSize;
        public HRESULT ddRVal;
        public IntPtr dwContext;
    }
}
