// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(1107,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8459616d-966e-4930-b658-54fa7e5a16d3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoMixerControl2 : IMFVideoMixerControl
    {
        // IMFVideoMixerControl
        [PreserveSig]
        new HRESULT SetStreamZOrder(/* [in] */ uint dwStreamID, /* [in] */ uint dwZ);
        
        [PreserveSig]
        new HRESULT GetStreamZOrder(/* [in] */ uint dwStreamID, /* [out] __RPC__out */ out uint pdwZ);
        
        [PreserveSig]
        new HRESULT SetStreamOutputRect(/* [in] */ uint dwStreamID, /* [in] __RPC__in */ ref MFVideoNormalizedRect pnrcOutput);
        
        [PreserveSig]
        new HRESULT GetStreamOutputRect(/* [in] */ uint dwStreamID, /* [out] __RPC__out */ out MFVideoNormalizedRect pnrcOutput);
        
        // IMFVideoMixerControl2
        [PreserveSig]
        HRESULT SetMixingPrefs(/* [in] */ uint dwMixFlags);
        
        [PreserveSig]
        HRESULT GetMixingPrefs(/* [out] __RPC__out */ out uint pdwMixFlags);
    }
}
