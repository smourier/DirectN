// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9cf0b1b6-fbaa-4b7f-88cf-cf1f130a0dce"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRMonitorConfig
    {
        [PreserveSig]
        HRESULT SetMonitor(/* [in] */ ref tagVMRGUID pGUID);
        
        [PreserveSig]
        HRESULT GetMonitor(/* [out] */ out tagVMRGUID pGUID);
        
        [PreserveSig]
        HRESULT SetDefaultMonitor(/* [in] */ ref tagVMRGUID pGUID);
        
        [PreserveSig]
        HRESULT GetDefaultMonitor(/* [out] */ out tagVMRGUID pGUID);
        
        [PreserveSig]
        HRESULT GetAvailableMonitors(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] tagVMRMONITORINFO[] pInfo, /* [in] */ uint dwMaxInfoArraySize, /* [out] */ out uint pdwNumDevices);
    }
}
