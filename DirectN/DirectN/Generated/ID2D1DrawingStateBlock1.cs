// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(1495,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents drawing state.
    /// </summary>
    [ComImport, Guid("689f1f85-c72e-4e33-8f19-85754efd5ace"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DrawingStateBlock1 : ID2D1DrawingStateBlock
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1DrawingStateBlock
        [PreserveSig]
        new void GetDescription(/* _Out_ */ out D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
        
        [PreserveSig]
        new void SetDescription(/* _In_ */ ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);
        
        [PreserveSig]
        new void SetTextRenderingParams(/* _In_opt_ */ IDWriteRenderingParams textRenderingParams);
        
        [PreserveSig]
        new void GetTextRenderingParams(/* _Outptr_result_maybenull_ */ out IDWriteRenderingParams textRenderingParams);
        
        // ID2D1DrawingStateBlock1
        [PreserveSig]
        void GetDescription(/* _Out_ */ out D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
        
        [PreserveSig]
        void SetDescription(/* _In_ */ ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
    }
}
