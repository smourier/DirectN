// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETDRIVERINFODATA
    {
        public IntPtr dhpdev;
        public uint dwSize;
        public uint dwFlags;
        public Guid guidInfo;
        public uint dwExpectedSize;
        public IntPtr lpvData;
        public uint dwActualSize;
        public HRESULT ddRVal;
    }
}
