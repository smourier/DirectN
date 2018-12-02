// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1326,9)
using System;
using System.Runtime.InteropServices;
using LPPALETTEENTRY = DirectN.tagPALETTEENTRY;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_PALETTE_GLOBAL = DirectN._DD_PALETTE_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SETENTRIESDATA
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
