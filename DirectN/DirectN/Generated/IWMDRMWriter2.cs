// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(2814,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("38ee7a94-40e2-4e10-aa3f-33fd3210ed5b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMWriter2 : IWMDRMWriter
    {
        // IWMDRMWriter
        [PreserveSig]
        new HRESULT GenerateKeySeed(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszKeySeed, /* [out][in] */ ref uint pcwchLength);
        
        [PreserveSig]
        new HRESULT GenerateKeyID(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszKeyID, /* [out][in] */ ref uint pcwchLength);
        
        [PreserveSig]
        new HRESULT GenerateSigningKeyPair(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszPrivKey, /* [out][in] */ ref uint pcwchPrivKeyLength, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszPubKey, /* [out][in] */ ref uint pcwchPubKeyLength);
        
        [PreserveSig]
        new HRESULT SetDRMAttribute(/* [in] */ ushort wStreamNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        // IWMDRMWriter2
        [PreserveSig]
        HRESULT SetWMDRMNetEncryption(/* [in] */ bool fSamplesEncrypted, /* [in] */ ref byte pbKeyID, /* [in] */ uint cbKeyID);
    }
}
