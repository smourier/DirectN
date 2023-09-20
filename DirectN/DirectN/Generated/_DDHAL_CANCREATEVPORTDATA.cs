// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_CANCREATEVIDEOPORT = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;
using LPDDVIDEOPORTDESC = DirectN._DDVIDEOPORTDESC;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_CANCREATEVPORTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDVideoPortDesc;
        public HRESULT ddRVal;
        public IntPtr CanCreateVideoPort;
    }
}
