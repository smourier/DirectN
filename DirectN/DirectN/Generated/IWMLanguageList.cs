// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("df683f00-2d49-4d8e-92b7-fb19f6a0dc57"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMLanguageList
    {
        [PreserveSig]
        HRESULT GetLanguageCount(/* [out] */ out ushort pwCount);
        
        [PreserveSig]
        HRESULT GetLanguageDetails(/* [in] */ ushort wIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguageString, /* [out][in] */ ref ushort pcchLanguageStringLength);
        
        [PreserveSig]
        HRESULT AddLanguageByRFC1766String(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszLanguageString, /* [out] */ out ushort pwIndex);
    }
}
