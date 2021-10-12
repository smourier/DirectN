// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(14772,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e08672de-f1e7-4ff4-a0a3-fc4b08e4caf8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMReader3 : IWMDRMReader2
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
        new HRESULT SetEvaluateOutputLevelLicenses(/* [in] */ bool fEvaluate);
        
        [PreserveSig]
        new HRESULT GetPlayOutputLevels(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] __tagDRM_PLAY_OPL[] pPlayOPL, /* [out][in] */ ref uint pcbLength, /* [out] */ out uint pdwMinAppComplianceLevel);
        
        [PreserveSig]
        new HRESULT GetCopyOutputLevels(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] __tagDRM_COPY_OPL[] pCopyOPL, /* [out][in] */ ref uint pcbLength, /* [out] */ out uint pdwMinAppComplianceLevel);
        
        [PreserveSig]
        new HRESULT TryNextLicense();
        
        // IWMDRMReader3
        [PreserveSig]
        HRESULT GetInclusionList(/* [out] */ out IntPtr ppGuids, /* [out] */ out uint pcGuids);
    }
}
