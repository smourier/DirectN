// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(2343,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents the drawing state of a render target: the antialiasing mode, transform, tags, and text-rendering options.
    /// </summary>
    [ComImport, Guid("28506e39-ebf6-46a1-bb47-fd85565ab957"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DrawingStateBlock : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1DrawingStateBlock
        [PreserveSig]
        void GetDescription(/* _Out_ */ out D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
        
        [PreserveSig]
        void SetDescription(/* _In_ */ ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
        
        [PreserveSig]
        void SetTextRenderingParams(/* _In_opt_ */ IDWriteRenderingParams textRenderingParams);
        
        [PreserveSig]
        void GetTextRenderingParams(/* _Outptr_result_maybenull_ */ out IDWriteRenderingParams textRenderingParams);
    }
}
