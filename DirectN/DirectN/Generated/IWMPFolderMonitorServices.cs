// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(10895,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("788c8743-e57f-439d-a468-5bc77f2e59c6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPFolderMonitorServices
    {
        [PreserveSig]
        HRESULT get_count(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT item(/* [in] */ int lIndex, /* [retval][out] */ out IntPtr pbstrFolder);
        
        [PreserveSig]
        HRESULT add(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrFolder);
        
        [PreserveSig]
        HRESULT remove(/* [in] */ int lIndex);
        
        [PreserveSig]
        HRESULT get_scanState(/* [retval][out] */ out WMPFolderScanState pwmpfss);
        
        [PreserveSig]
        HRESULT get_currentFolder(/* [retval][out] */ out IntPtr pbstrFolder);
        
        [PreserveSig]
        HRESULT get_scannedFilesCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT get_addedFilesCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT get_updateProgress(/* [retval][out] */ out long plProgress);
        
        [PreserveSig]
        HRESULT startScan();
        
        [PreserveSig]
        HRESULT stopScan();
    }
}
