﻿// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d2827540-3ee7-432c-b14c-dc17f085d3b3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMReader
    {
        [PreserveSig]
        HRESULT AcquireLicense(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT CancelLicenseAcquisition();
        
        [PreserveSig]
        HRESULT Individualize(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT CancelIndividualization();
        
        [PreserveSig]
        HRESULT MonitorLicenseAcquisition();
        
        [PreserveSig]
        HRESULT CancelMonitorLicenseAcquisition();
        
        [PreserveSig]
        HRESULT SetDRMProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrName, /* [in] */ WMT_ATTR_DATATYPE dwType, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        [PreserveSig]
        HRESULT GetDRMProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrName, /* [out] */ out WMT_ATTR_DATATYPE pdwType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
    }
}
