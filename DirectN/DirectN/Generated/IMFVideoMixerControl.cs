// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(970,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a5c6c53f-c202-4aa5-9695-175ba8c508a5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoMixerControl
    {
        [PreserveSig]
        HRESULT SetStreamZOrder(/* [in] */ uint dwStreamID, /* [in] */ uint dwZ);
        
        [PreserveSig]
        HRESULT GetStreamZOrder(/* [in] */ uint dwStreamID, /* [out] __RPC__out */ out uint pdwZ);
        
        [PreserveSig]
        HRESULT SetStreamOutputRect(/* [in] */ uint dwStreamID, /* [in] __RPC__in */ ref MFVideoNormalizedRect pnrcOutput);
        
        [PreserveSig]
        HRESULT GetStreamOutputRect(/* [in] */ uint dwStreamID, /* [out] __RPC__out */ out MFVideoNormalizedRect pnrcOutput);
    }
}
