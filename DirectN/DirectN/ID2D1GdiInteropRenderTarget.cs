using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e0db51c3-6f77-4bae-b3d5-e47509b35838"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1GdiInteropRenderTarget
    {
        [PreserveSig]
        HRESULT GetDC(D2D1_DC_INITIALIZE_MODE mode, out IntPtr hdc);

        [PreserveSig]
        HRESULT ReleaseDC(ref RECT update);
    }
}
