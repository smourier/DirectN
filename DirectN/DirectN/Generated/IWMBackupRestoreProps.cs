// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3c8e0da6-996f-4ff3-a1af-4838f9377e2e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMBackupRestoreProps
    {
        [PreserveSig]
        HRESULT GetPropCount(/* [out] */ out ushort pcProps);
        
        [PreserveSig]
        HRESULT GetPropByIndex(/* [in] */ ushort wIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchNameLen, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        HRESULT GetPropByName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        HRESULT SetPropW(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        [PreserveSig]
        HRESULT RemovePropW(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pcwszName);
        
        [PreserveSig]
        HRESULT RemoveAllProps();
    }
}
