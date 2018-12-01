// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1569,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a color context to be used with the Color Management Effect.
    /// </summary>
    [Guid("1ab42875-c57f-4be9-bd85-9cd78d6f55ee"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ColorContext1
    {
        [PreserveSig]
        D2D1_COLOR_CONTEXT_TYPE GetColorContextType();
        
        [PreserveSig]
        DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace();
        
        [PreserveSig]
        HRESULT GetSimpleColorProfile(/* _Out_ */ out D2D1_SIMPLE_COLOR_PROFILE simpleProfile);
    }
}
