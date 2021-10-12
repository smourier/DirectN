// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5434,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// ////////////////////// LDDM display miniport VidPN management DDI /////////////////////////////
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_ISSUPPORTEDVIDPN
    {
        public IntPtr hDesiredVidPn;
        public byte IsVidPnSupported;
    }
}
