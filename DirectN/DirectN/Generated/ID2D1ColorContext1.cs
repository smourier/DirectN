// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(1569,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a color context to be used with the Color Management Effect.
    /// </summary>
    [ComImport, Guid("1ab42875-c57f-4be9-bd85-9cd78d6f55ee"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ColorContext1 : ID2D1ColorContext
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1ColorContext
        [PreserveSig]
        new D2D1_COLOR_SPACE GetColorSpace();
        
        [PreserveSig]
        new uint GetProfileSize();
        
        [PreserveSig]
        new HRESULT GetProfile(/* _Out_writes_(profileSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] profile, int profileSize);
        
        // ID2D1ColorContext1
        [PreserveSig]
        D2D1_COLOR_CONTEXT_TYPE GetColorContextType();
        
        [PreserveSig]
        DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace();
        
        [PreserveSig]
        HRESULT GetSimpleColorProfile(/* _Out_ */ out D2D1_SIMPLE_COLOR_PROFILE simpleProfile);
    }
}
