// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(9718,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bd94dbeb-417f-4928-aa06-087d56ed9b59"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPCdromBurn
    {
        [PreserveSig]
        HRESULT isAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItem, /* [retval][out] */ out bool pIsAvailable);
        
        [PreserveSig]
        HRESULT getItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItem, /* [retval][out] */ out IntPtr pbstrVal);
        
        [PreserveSig]
        HRESULT get_label(/* [retval][out] */ out IntPtr pbstrLabel);
        
        [PreserveSig]
        HRESULT put_label(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrLabel);
        
        [PreserveSig]
        HRESULT get_burnFormat(/* [retval][out] */ out WMPBurnFormat pwmpbf);
        
        [PreserveSig]
        HRESULT put_burnFormat(/* [in] */ WMPBurnFormat wmpbf);
        
        [PreserveSig]
        HRESULT get_burnPlaylist(/* [retval][out] */ out IWMPPlaylist ppPlaylist);
        
        [PreserveSig]
        HRESULT put_burnPlaylist(/* [in] */ IWMPPlaylist pPlaylist);
        
        [PreserveSig]
        HRESULT refreshStatus();
        
        [PreserveSig]
        HRESULT get_burnState(/* [retval][out] */ out WMPBurnState pwmpbs);
        
        [PreserveSig]
        HRESULT get_burnProgress(/* [retval][out] */ out long plProgress);
        
        [PreserveSig]
        HRESULT startBurn();
        
        [PreserveSig]
        HRESULT stopBurn();
        
        [PreserveSig]
        HRESULT erase();
    }
}
