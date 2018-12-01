// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(1883,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6f79d558-3e96-4549-a1d1-7d75d2288814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyDescription
    {
        [PreserveSig]
        HRESULT GetPropertyKey(/* [out] __RPC__out */ out _tagpropertykey pkey);
        
        [PreserveSig]
        HRESULT GetCanonicalName(/* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszName);
        
        [PreserveSig]
        HRESULT GetPropertyType(/* [out] __RPC__out */ out ushort pvartype);
        
        [PreserveSig]
        HRESULT GetDisplayName(/* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszName);
        
        [PreserveSig]
        HRESULT GetEditInvitation(/* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszInvite);
        
        [PreserveSig]
        HRESULT GetTypeFlags(/* [in] */ PROPDESC_TYPE_FLAGS mask, /* [out] __RPC__out */ out PROPDESC_TYPE_FLAGS ppdtFlags);
        
        [PreserveSig]
        HRESULT GetViewFlags(/* [out] __RPC__out */ out PROPDESC_VIEW_FLAGS ppdvFlags);
        
        [PreserveSig]
        HRESULT GetDefaultColumnWidth(/* [out] __RPC__out */ out uint pcxChars);
        
        [PreserveSig]
        HRESULT GetDisplayType(/* [out] __RPC__out */ out PROPDESC_DISPLAYTYPE pdisplaytype);
        
        [PreserveSig]
        HRESULT GetColumnState(/* [out] __RPC__out */ out uint pcsFlags);
        
        [PreserveSig]
        HRESULT GetGroupingRange(/* [out] __RPC__out */ out PROPDESC_GROUPING_RANGE pgr);
        
        [PreserveSig]
        HRESULT GetRelativeDescriptionType(/* [out] __RPC__out */ out PROPDESC_RELATIVEDESCRIPTION_TYPE prdt);
        
        [PreserveSig]
        HRESULT GetRelativeDescription(/* [in] __RPC__in */ PropVariant propvar1, /* [in] __RPC__in */ PropVariant propvar2, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszDesc1, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszDesc2);
        
        [PreserveSig]
        HRESULT GetSortDescription(/* [out] __RPC__out */ out PROPDESC_SORTDESCRIPTION psd);
        
        [PreserveSig]
        HRESULT GetSortDescriptionLabel(/* [in] */ bool fDescending, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszDescription);
        
        [PreserveSig]
        HRESULT GetAggregationType(/* [out] __RPC__out */ out PROPDESC_AGGREGATION_TYPE paggtype);
        
        [PreserveSig]
        HRESULT GetConditionType(/* [out] __RPC__out */ out PROPDESC_CONDITION_TYPE pcontype, /* [out] __RPC__out */ out tagCONDITION_OPERATION popDefault);
        
        [PreserveSig]
        HRESULT GetEnumTypeList(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT CoerceToCanonicalValue(/* [annotation][out][in] _Inout_ */ PropVariant ppropvar);
        
        [PreserveSig]
        HRESULT FormatForDisplay(/* [in] __RPC__in */ PropVariant propvar, /* [in] */ PROPDESC_FORMAT_FLAGS pdfFlags, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszDisplay);
        
        [PreserveSig]
        HRESULT IsValueCanonical(/* [in] __RPC__in */ PropVariant propvar);
    }
}
