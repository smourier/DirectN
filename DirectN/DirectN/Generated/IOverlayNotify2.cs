// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("680efa10-d535-11d1-87c8-00a0c9223196"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
