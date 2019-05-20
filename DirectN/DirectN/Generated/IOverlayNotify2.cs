// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(5725,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("680efa10-d535-11d1-87c8-00a0c9223196"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOverlayNotify2 : IOverlayNotify
    {
        // IOverlayNotify
        [PreserveSig]
        new HRESULT OnPaletteChange(/* [in] */ uint dwColors, /* [in] */ ref tagPALETTEENTRY pPalette);
        
        [PreserveSig]
        new HRESULT OnClipChange(/* [in] */ ref tagRECT pSourceRect, /* [in] */ ref tagRECT pDestinationRect, /* [in] */ ref _RGNDATA pRgnData);
        
        [PreserveSig]
        new HRESULT OnColorKeyChange(/* [in] */ ref tagCOLORKEY pColorKey);
        
        [PreserveSig]
        new HRESULT OnPositionChange(/* [in] */ ref tagRECT pSourceRect, /* [in] */ ref tagRECT pDestinationRect);
        
        // IOverlayNotify2
        [PreserveSig]
        HRESULT OnDisplayChange(IntPtr hMonitor);
    }
}
