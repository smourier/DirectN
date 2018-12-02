// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1813,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETMOCOMPFORMATSDATA
    {
        public IntPtr lpDD;
        public IntPtr lpGuid;
        public uint dwNumFormats;
        public IntPtr lpFormats;
        public HRESULT ddRVal;
    }
}
