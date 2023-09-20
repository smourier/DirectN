// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("00855b90-ce1b-11d0-bd4f-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFileSinkFilter2 : IFileSinkFilter
    {
        // IFileSinkFilter
        [PreserveSig]
        new HRESULT SetFileName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, /* optional(_AMMediaType) */ IntPtr pmt);
        
        [PreserveSig]
        new HRESULT GetCurFile(/* [annotation][out] _Out_ */ out IntPtr ppszFileName, /* [annotation][out] _Out_ */ out _AMMediaType pmt);
        
        // IFileSinkFilter2
        [PreserveSig]
        HRESULT SetMode(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetMode(/* [annotation][out] _Out_ */ out uint pdwFlags);
    }
}
