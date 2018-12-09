// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(5589,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a868a0-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOverlayNotify
    {
        [PreserveSig]
        HRESULT OnPaletteChange(/* [in] */ uint dwColors, /* [in] */ ref tagPALETTEENTRY pPalette);
        
        [PreserveSig]
        HRESULT OnClipChange(/* [in] */ ref tagRECT pSourceRect, /* [in] */ ref tagRECT pDestinationRect, /* [in] */ ref _RGNDATA pRgnData);
        
        [PreserveSig]
        HRESULT OnColorKeyChange(/* [in] */ ref tagCOLORKEY pColorKey);
        
        [PreserveSig]
        HRESULT OnPositionChange(/* [in] */ ref tagRECT pSourceRect, /* [in] */ ref tagRECT pDestinationRect);
    }
}
