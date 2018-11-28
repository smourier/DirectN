using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("28506e39-ebf6-46a1-bb47-fd85565ab957"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1DrawingStateBlock : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1DrawingStateBlock
        [PreserveSig]
        void GetDescription(ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);

        [PreserveSig]
        void SetDescription(ref D2D1_DRAWING_STATE_DESCRIPTION stateDescription);

        [PreserveSig]
        void SetTextRenderingParams(IDWriteRenderingParams textRenderingParams);

        [PreserveSig]
        void GetTextRenderingParams(out IDWriteRenderingParams textRenderingParams);
    }
}
