// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(17022,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e0da439f-d331-496a-bece-18e5bac5dd23"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMTranscryptor2 : IWMDRMTranscryptor
    {
        // IWMDRMTranscryptor
        [PreserveSig]
        new HRESULT Initialize(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrFileName, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbLicenseRequestMsg, /* [in] */ uint cbLicenseRequestMsg, /* [out] */ out INSSBuffer ppLicenseResponseMsg, /* [in] */ IWMStatusCallback pCallback, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        new HRESULT Seek(/* [in] */ ulong hnsTime);
        
        [PreserveSig]
        new HRESULT Read(/* [in] */ ref byte pbData, /* [in] */ ref uint pcbData);
        
        [PreserveSig]
        new HRESULT Close();
        
        // IWMDRMTranscryptor2
        [PreserveSig]
        HRESULT SeekEx(/* [in] */ ulong cnsStartTime, /* [in] */ ulong cnsDuration, /* [in] */ float flRate, /* [in] */ bool fIncludeFileHeader);
        
        [PreserveSig]
        HRESULT ZeroAdjustTimestamps(/* [in] */ bool fEnable);
        
        [PreserveSig]
        HRESULT GetSeekStartTime(/* [out] */ out ulong pcnsTime);
        
        [PreserveSig]
        HRESULT GetDuration(/* [out] */ out ulong pcnsDuration);
    }
}
