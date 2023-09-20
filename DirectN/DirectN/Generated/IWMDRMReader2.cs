// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("befe7a75-9f1d-4075-b9d9-a3c37bda49a0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMReader2 : IWMDRMReader
    {
        // IWMDRMReader
        [PreserveSig]
        new HRESULT AcquireLicense(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        new HRESULT CancelLicenseAcquisition();
        
        [PreserveSig]
        new HRESULT Individualize(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        new HRESULT CancelIndividualization();
        
        [PreserveSig]
        new HRESULT MonitorLicenseAcquisition();
        
        [PreserveSig]
        new HRESULT CancelMonitorLicenseAcquisition();
        
        [PreserveSig]
        new HRESULT SetDRMProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrName, /* [in] */ WMT_ATTR_DATATYPE dwType, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        [PreserveSig]
        new HRESULT GetDRMProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrName, /* [out] */ out WMT_ATTR_DATATYPE pdwType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        // IWMDRMReader2
        [PreserveSig]
        HRESULT SetEvaluateOutputLevelLicenses(/* [in] */ bool fEvaluate);
        
        [PreserveSig]
        HRESULT GetPlayOutputLevels(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] __tagDRM_PLAY_OPL[] pPlayOPL, /* [out][in] */ ref uint pcbLength, /* [out] */ out uint pdwMinAppComplianceLevel);
        
        [PreserveSig]
        HRESULT GetCopyOutputLevels(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] __tagDRM_COPY_OPL[] pCopyOPL, /* [out][in] */ ref uint pcbLength, /* [out] */ out uint pdwMinAppComplianceLevel);
        
        [PreserveSig]
        HRESULT TryNextLicense();
    }
}
