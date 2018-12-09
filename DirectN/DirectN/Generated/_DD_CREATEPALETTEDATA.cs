// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1373,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_PALETTE_GLOBAL = DirectN._DD_PALETTE_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_CREATEPALETTEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDPalette;
        public IntPtr lpColorTable;
        public HRESULT ddRVal;
        public IntPtr CreatePalette;
        public bool is_excl;
    }
}
