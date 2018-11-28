using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("689f1f85-c72e-4e33-8f19-85754efd5ace"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1DrawingStateBlock1 : ID2D1DrawingStateBlock
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1DrawingStateBlock
        [PreserveSig]
        new void GetDescription(ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);

        [PreserveSig]
        new void SetDescription(ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);

        [PreserveSig]
        new void SetTextRenderingParams(IDWriteRenderingParams textRenderingParams);

        [PreserveSig]
        new void GetTextRenderingParams(out IDWriteRenderingParams textRenderingParams);

        // ID2D1DrawingStateBlock1
        [PreserveSig]
        void GetDescription(out D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);

        [PreserveSig]
        void SetDescription(ref D2D1_DRAWING_STATE_DESCRIPTION1 stateDescription);
    }
}
