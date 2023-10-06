// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using D3DKMDT_HVIDPN = DirectN.D3DKMDT_HVIDPN__;

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
