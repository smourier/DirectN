// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(16902,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("69059850-6e6f-4bb2-806f-71863ddfc471"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMTranscryptor
    {
        [PreserveSig]
        HRESULT Initialize(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrFileName, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbLicenseRequestMsg, /* [in] */ uint cbLicenseRequestMsg, /* [out] */ out INSSBuffer ppLicenseResponseMsg, /* [in] */ IWMStatusCallback pCallback, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT Seek(/* [in] */ ulong hnsTime);
        
        [PreserveSig]
        HRESULT Read(/* [in] */ ref byte pbData, /* [in] */ ref uint pcbData);
        
        [PreserveSig]
        HRESULT Close();
    }
}
