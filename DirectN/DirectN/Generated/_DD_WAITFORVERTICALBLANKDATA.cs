// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(1391,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_WAITFORVERTICALBLANKDATA
    {
        public IntPtr lpDD;
        public uint dwFlags;
        public uint bIsInVB;
        public IntPtr hEvent;
        public HRESULT ddRVal;
        public IntPtr WaitForVerticalBlank;
    }
}
