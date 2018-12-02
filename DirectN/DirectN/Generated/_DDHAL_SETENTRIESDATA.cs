// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2264,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALPALCB_SETENTRIES = System.IntPtr;
using LPDDRAWI_DDRAWPALETTE_GBL = DirectN._DDRAWI_DDRAWPALETTE_GBL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;
using LPPALETTEENTRY = DirectN.tagPALETTEENTRY;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_SETENTRIESDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDPalette;
        public uint dwBase;
        public uint dwNumEntries;
        public IntPtr lpEntries;
        public HRESULT ddRVal;
        public IntPtr SetEntries;
    }
}
