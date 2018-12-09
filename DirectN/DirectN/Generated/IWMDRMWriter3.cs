// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(2936,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a7184082-a4aa-4dde-ac9c-e75dbd1117ce"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMWriter3 : IWMDRMWriter2
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
        new HRESULT SetWMDRMNetEncryption(/* [in] */ bool fSamplesEncrypted, /* [in] */ ref byte pbKeyID, /* [in] */ uint cbKeyID);
        
        // IWMDRMWriter3
        [PreserveSig]
        HRESULT SetProtectStreamSamples(/* [in] */ ref WMDRM_IMPORT_INIT_STRUCT pImportInitStruct);
    }
}
