// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(3241,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ca724e8a-c3e6-442b-88a4-6fb0db8035a3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertySystem
    {
        [PreserveSig]
        HRESULT GetPropertyDescription(/* [in] __RPC__in */ ref _tagpropertykey propkey, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT GetPropertyDescriptionByName(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string pszCanonicalName, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT GetPropertyDescriptionListFromString(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string pszPropList, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT EnumeratePropertyDescriptions(/* [in] */ PROPDESC_ENUMFILTER filterOn, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT FormatForDisplay(/* [in] __RPC__in */ ref _tagpropertykey key, /* [in] __RPC__in */ PropVariant propvar, /* [in] */ PROPDESC_FORMAT_FLAGS pdff, /* [size_is][string][out] __RPC__out_ecount_full_string(cchText) */ [MarshalAs(UnmanagedType.LPWStr)] string pszText, /* [range][in] __RPC__in_range(0,0x8000) */ uint cchText);
        
        [PreserveSig]
        HRESULT FormatForDisplayAlloc(/* [in] __RPC__in */ ref _tagpropertykey key, /* [in] __RPC__in */ PropVariant propvar, /* [in] */ PROPDESC_FORMAT_FLAGS pdff, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszDisplay);
        
        [PreserveSig]
        HRESULT RegisterPropertySchema(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string pszPath);
        
        [PreserveSig]
        HRESULT UnregisterPropertySchema(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string pszPath);
        
        [PreserveSig]
        HRESULT RefreshPropertySchema();
    }
}
