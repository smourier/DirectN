// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(2711,5)
using System;
using System.Runtime.InteropServices;
using PROPERTYKEY = DirectN._tagpropertykey;
using SHCOLSTATEF = System.UInt32;
using VARTYPE = System.UInt16;

namespace DirectN
{
    [Guid("078f91bd-29a2-440f-924e-46a291524520"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyDescriptionSearchInfo : IPropertyDescription
    {
        // IPropertyDescription
        [PreserveSig]
        new HRESULT GetPropertyKey(/* [out] __RPC__out */ out PROPERTYKEY pkey);
        
        [PreserveSig]
        new HRESULT GetCanonicalName(/* optional(LPWSTR) */ out IntPtr ppszName);
        
        [PreserveSig]
        new HRESULT GetPropertyType(/* [out] __RPC__out */ out VARTYPE pvartype);
        
        [PreserveSig]
        new HRESULT GetDisplayName(/* optional(LPWSTR) */ out IntPtr ppszName);
        
        [PreserveSig]
        new HRESULT GetEditInvitation(/* optional(LPWSTR) */ out IntPtr ppszInvite);
        
        [PreserveSig]
        new HRESULT GetTypeFlags(/* [in] */ PROPDESC_TYPE_FLAGS mask, /* [out] __RPC__out */ out PROPDESC_TYPE_FLAGS ppdtFlags);
        
        [PreserveSig]
        new HRESULT GetViewFlags(/* [out] __RPC__out */ out PROPDESC_VIEW_FLAGS ppdvFlags);
        
        [PreserveSig]
        new HRESULT GetDefaultColumnWidth(/* [out] __RPC__out */ out uint pcxChars);
        
        [PreserveSig]
        new HRESULT GetDisplayType(/* [out] __RPC__out */ out PROPDESC_DISPLAYTYPE pdisplaytype);
        
        [PreserveSig]
        new HRESULT GetColumnState(/* [out] __RPC__out */ out SHCOLSTATEF pcsFlags);
        
        [PreserveSig]
        new HRESULT GetGroupingRange(/* [out] __RPC__out */ out PROPDESC_GROUPING_RANGE pgr);
        
        [PreserveSig]
        new HRESULT GetRelativeDescriptionType(/* [out] __RPC__out */ out PROPDESC_RELATIVEDESCRIPTION_TYPE prdt);
        
        [PreserveSig]
        new HRESULT GetRelativeDescription(/* [in] __RPC__in */ PropVariant propvar1, /* [in] __RPC__in */ PropVariant propvar2, /* optional(LPWSTR) */ out IntPtr ppszDesc1, /* optional(LPWSTR) */ out IntPtr ppszDesc2);
        
        [PreserveSig]
        new HRESULT GetSortDescription(/* [out] __RPC__out */ out PROPDESC_SORTDESCRIPTION psd);
        
        [PreserveSig]
        new HRESULT GetSortDescriptionLabel(/* [in] */ bool fDescending, /* optional(LPWSTR) */ out IntPtr ppszDescription);
        
        [PreserveSig]
        new HRESULT GetAggregationType(/* [out] __RPC__out */ out PROPDESC_AGGREGATION_TYPE paggtype);
        
        [PreserveSig]
        new HRESULT GetConditionType(/* [out] __RPC__out */ out PROPDESC_CONDITION_TYPE pcontype, /* [out] __RPC__out */ out tagCONDITION_OPERATION popDefault);
        
        [PreserveSig]
        new HRESULT GetEnumTypeList(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        new HRESULT CoerceToCanonicalValue(/* [annotation][out][in] _Inout_ */ PropVariant ppropvar);
        
        [PreserveSig]
        new HRESULT FormatForDisplay(/* [in] __RPC__in */ PropVariant propvar, /* [in] */ PROPDESC_FORMAT_FLAGS pdfFlags, /* optional(LPWSTR) */ out IntPtr ppszDisplay);
        
        [PreserveSig]
        new HRESULT IsValueCanonical(/* [in] __RPC__in */ PropVariant propvar);
        
        // IPropertyDescriptionSearchInfo
        [PreserveSig]
        HRESULT GetSearchInfoFlags(/* [out] __RPC__out */ out PROPDESC_SEARCHINFO_FLAGS ppdsiFlags);
        
        [PreserveSig]
        HRESULT GetColumnIndexType(/* [out] __RPC__out */ out PROPDESC_COLUMNINDEX_TYPE ppdciType);
        
        [PreserveSig]
        HRESULT GetProjectionString(/* optional(LPWSTR) */ out IntPtr ppszProjection);
        
        [PreserveSig]
        HRESULT GetMaxSize(/* [out] __RPC__out */ out uint pcbMaxSize);
    }
}
