// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1497,9)
using System;
using System.Runtime.InteropServices;
using LPDDPIXELFORMAT = DirectN._DDPIXELFORMAT;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_VIDEOPORT_LOCAL = DirectN._DD_VIDEOPORT_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETVPORTINPUTFORMATDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public uint dwFlags;
        public IntPtr lpddpfFormat;
        public uint dwNumFormats;
        public HRESULT ddRVal;
        public IntPtr GetVideoPortInputFormats;
    }
}
