// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_GETOUTPUTFORMATS = System.IntPtr;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETVPORTOUTPUTFORMATDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public uint dwFlags;
        public IntPtr lpddpfInputFormat;
        public IntPtr lpddpfOutputFormats;
        public uint dwNumFormats;
        public HRESULT ddRVal;
        public IntPtr GetVideoPortOutputFormats;
    }
}
