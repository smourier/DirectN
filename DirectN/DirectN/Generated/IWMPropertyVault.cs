// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("72995a79-5090-42a4-9c8c-d9d0b6d34be5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPropertyVault
    {
        [PreserveSig]
        HRESULT GetPropertyCount(/* [in] */ ref uint pdwCount);
        
        [PreserveSig]
        HRESULT GetPropertyByName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwSize);
        
        [PreserveSig]
        HRESULT SetProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE pType, /* [in] */ ref byte pValue, /* [in] */ uint dwSize);
        
        [PreserveSig]
        HRESULT GetPropertyByIndex(/* [in] */ uint dwIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out][in] */ ref uint pdwNameLen, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwSize);
        
        [PreserveSig]
        HRESULT CopyPropertiesFrom(/* [in] */ IWMPropertyVault pIWMPropertyVault);
        
        [PreserveSig]
        HRESULT Clear();
    }
}
