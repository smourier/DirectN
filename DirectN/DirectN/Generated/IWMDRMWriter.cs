// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(2666,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d6ea5dd0-12a0-43f4-90ab-a3fd451e6a07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMWriter
    {
        [PreserveSig]
        HRESULT GenerateKeySeed(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszKeySeed, /* [out][in] */ ref uint pcwchLength);
        
        [PreserveSig]
        HRESULT GenerateKeyID(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszKeyID, /* [out][in] */ ref uint pcwchLength);
        
        [PreserveSig]
        HRESULT GenerateSigningKeyPair(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszPrivKey, /* [out][in] */ ref uint pcwchPrivKeyLength, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszPubKey, /* [out][in] */ ref uint pcwchPubKeyLength);
        
        [PreserveSig]
        HRESULT SetDRMAttribute(/* [in] */ ushort wStreamNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
    }
}
