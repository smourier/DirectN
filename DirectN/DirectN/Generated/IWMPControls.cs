// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(1331,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("74c09e02-f828-11d2-a74b-00a0c905f36e"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPControls
    {
        [PreserveSig]
        HRESULT get_isAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItem, /* [retval][out] */ out bool pIsAvailable);
        
        [PreserveSig]
        HRESULT play();
        
        [PreserveSig]
        HRESULT stop();
        
        [PreserveSig]
        HRESULT pause();
        
        [PreserveSig]
        HRESULT fastForward();
        
        [PreserveSig]
        HRESULT fastReverse();
        
        [PreserveSig]
        HRESULT get_currentPosition(/* [retval][out] */ out double pdCurrentPosition);
        
        [PreserveSig]
        HRESULT put_currentPosition(/* [in] */ double dCurrentPosition);
        
        [PreserveSig]
        HRESULT get_currentPositionString(/* [retval][out] */ out IntPtr pbstrCurrentPosition);
        
        [PreserveSig]
        HRESULT next();
        
        [PreserveSig]
        HRESULT previous();
        
        [PreserveSig]
        HRESULT get_currentItem(/* [retval][out] */ out IWMPMedia ppIWMPMedia);
        
        [PreserveSig]
        HRESULT put_currentItem(/* [in] */ IWMPMedia pIWMPMedia);
        
        [PreserveSig]
        HRESULT get_currentMarker(/* [retval][out] */ out long plMarker);
        
        [PreserveSig]
        HRESULT put_currentMarker(/* [in] */ int lMarker);
        
        [PreserveSig]
        HRESULT playItem(/* [in] */ IWMPMedia pIWMPMedia);
    }
}
