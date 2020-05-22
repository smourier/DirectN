// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(1674,9)
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
