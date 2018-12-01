// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(1705,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f67e0edd-9e3d-4ecc-8c32-4183253dfe70"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextFormat2
    {
        [PreserveSig]
        HRESULT SetLineSpacing(/* _In_ */ ref DWRITE_LINE_SPACING lineSpacingOptions);
        
        [PreserveSig]
        HRESULT GetLineSpacing(/* _Out_ */ out DWRITE_LINE_SPACING lineSpacingOptions);
    }
}
