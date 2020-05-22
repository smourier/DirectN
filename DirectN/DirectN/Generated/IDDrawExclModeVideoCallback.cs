// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(23996,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("913c24a0-20ab-11d2-9038-00a0c9697298"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDDrawExclModeVideoCallback
    {
        [PreserveSig]
        HRESULT OnUpdateOverlay(/* [in] */ bool bBefore, /* [in] */ uint dwFlags, /* [in] */ bool bOldVisible, /* [in] */ ref tagRECT prcOldSrc, /* [in] */ ref tagRECT prcOldDest, /* [in] */ bool bNewVisible, /* [in] */ ref tagRECT prcNewSrc, /* [in] */ ref tagRECT prcNewDest);
        
        [PreserveSig]
        HRESULT OnUpdateColorKey(/* [in] */ ref tagCOLORKEY pKey, /* [in] */ uint dwColor);
        
        [PreserveSig]
        HRESULT OnUpdateSize(/* [in] */ uint dwWidth, /* [in] */ uint dwHeight, /* [in] */ uint dwARWidth, /* [in] */ uint dwARHeight);
    }
}
