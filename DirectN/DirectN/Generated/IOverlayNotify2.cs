// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(5725,5)
using System;
using System.Runtime.InteropServices;
using PALETTEENTRY = DirectN.tagPALETTEENTRY;
using RECT = DirectN.tagRECT;
using RGNDATA = DirectN._RGNDATA;

namespace DirectN
{
    [Guid("680efa10-d535-11d1-87c8-00a0c9223196"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOverlayNotify2 : IOverlayNotify
    {
        // IOverlayNotify
        [PreserveSig]
        new HRESULT OnPaletteChange(/* [in] */ uint dwColors, /* [in] */ ref PALETTEENTRY pPalette);
        
        [PreserveSig]
        new HRESULT OnClipChange(/* [in] */ ref RECT pSourceRect, /* [in] */ ref RECT pDestinationRect, /* [in] */ ref RGNDATA pRgnData);
        
        [PreserveSig]
        new HRESULT OnColorKeyChange(/* [in] */ ref tagCOLORKEY pColorKey);
        
        [PreserveSig]
        new HRESULT OnPositionChange(/* [in] */ ref RECT pSourceRect, /* [in] */ ref RECT pDestinationRect);
        
        // IOverlayNotify2
        [PreserveSig]
        HRESULT OnDisplayChange(ref IntPtr hMonitor);
    }
}
