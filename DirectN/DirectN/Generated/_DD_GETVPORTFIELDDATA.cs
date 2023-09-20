// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_VIDEOPORT_LOCAL = DirectN._DD_VIDEOPORT_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETVPORTFIELDDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public bool bField;
        public HRESULT ddRVal;
        public IntPtr GetVideoPortField;
    }
}
