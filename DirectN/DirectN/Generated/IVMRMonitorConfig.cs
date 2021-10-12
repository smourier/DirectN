// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(20487,5)
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
