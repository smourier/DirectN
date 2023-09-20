// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9e5530c5-7034-48b4-bb46-0b8a6efc8e36"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRFilterConfig
    {
        [PreserveSig]
        HRESULT SetImageCompositor(/* [in] */ IVMRImageCompositor lpVMRImgCompositor);
        
        [PreserveSig]
        HRESULT SetNumberOfStreams(/* [in] */ uint dwMaxStreams);
        
        [PreserveSig]
        HRESULT GetNumberOfStreams(/* [out] */ out uint pdwMaxStreams);
        
        [PreserveSig]
        HRESULT SetRenderingPrefs(/* [in] */ uint dwRenderFlags);
        
        [PreserveSig]
        HRESULT GetRenderingPrefs(/* [out] */ out uint pdwRenderFlags);
        
        [PreserveSig]
        HRESULT SetRenderingMode(/* [in] */ uint Mode);
        
        [PreserveSig]
        HRESULT GetRenderingMode(/* [out] */ out uint pMode);
    }
}
