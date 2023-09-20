// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("46ad648d-53f1-4a74-92e2-2a1b68d63fd4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPStringCollection2 : IWMPStringCollection
    {
        // IWMPStringCollection
        [PreserveSig]
        new HRESULT get_count(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        new HRESULT item(/* [in] */ int lIndex, /* [retval][out] */ out IntPtr pbstrString);
        
        // IWMPStringCollection2
        [PreserveSig]
        HRESULT isIdentical(/* [in] */ IWMPStringCollection2 pIWMPStringCollection2, /* [retval][out] */ out bool pvbool);
        
        [PreserveSig]
        HRESULT getItemInfo(/* [in] */ int lCollectionIndex, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out IntPtr pbstrValue);
        
        [PreserveSig]
        HRESULT getAttributeCountByType(/* [in] */ int lCollectionIndex, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrType, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrLanguage, /* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT getItemInfoByType(/* [in] */ int lCollectionIndex, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrType, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrLanguage, /* [in] */ int lAttributeIndex, /* [retval][out] */ out IntPtr pvarValue);
    }
}
