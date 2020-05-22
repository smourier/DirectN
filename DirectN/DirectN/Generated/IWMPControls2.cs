// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(5171,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6f030d25-0890-480f-9775-1f7e40ab5b8e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPControls2 : IWMPControls
    {
        // IWMPControls
        [PreserveSig]
        new HRESULT get_isAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItem, /* [retval][out] */ out bool pIsAvailable);
        
        [PreserveSig]
        new HRESULT play();
        
        [PreserveSig]
        new HRESULT stop();
        
        [PreserveSig]
        new HRESULT pause();
        
        [PreserveSig]
        new HRESULT fastForward();
        
        [PreserveSig]
        new HRESULT fastReverse();
        
        [PreserveSig]
        new HRESULT get_currentPosition(/* [retval][out] */ out double pdCurrentPosition);
        
        [PreserveSig]
        new HRESULT put_currentPosition(/* [in] */ double dCurrentPosition);
        
        [PreserveSig]
        new HRESULT get_currentPositionString(/* [retval][out] */ out IntPtr pbstrCurrentPosition);
        
        [PreserveSig]
        new HRESULT next();
        
        [PreserveSig]
        new HRESULT previous();
        
        [PreserveSig]
        new HRESULT get_currentItem(/* [retval][out] */ out IWMPMedia ppIWMPMedia);
        
        [PreserveSig]
        new HRESULT put_currentItem(/* [in] */ IWMPMedia pIWMPMedia);
        
        [PreserveSig]
        new HRESULT get_currentMarker(/* [retval][out] */ out long plMarker);
        
        [PreserveSig]
        new HRESULT put_currentMarker(/* [in] */ int lMarker);
        
        [PreserveSig]
        new HRESULT playItem(/* [in] */ IWMPMedia pIWMPMedia);
        
        // IWMPControls2
        [PreserveSig]
        HRESULT step(/* [in] */ int lStep);
    }
}
