// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3506,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CONFIGURESHAREDRESOURCE
    {
        public uint hDevice;
        public uint hResource;
        public byte IsDwm;
        public IntPtr hProcess;
        public byte AllowAccess;
    }
}
