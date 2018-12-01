// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(2196,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("57d2eded-5062-400e-b107-5dae79fe57a6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyDescription2 : IPropertyDescription
    {
        // IPropertyDescription
        [PreserveSig]
        new HRESULT GetPropertyKey(/* [out] __RPC__out */ out _tagpropertykey pkey);
        
        [PreserveSig]
        new HRESULT GetCanonicalName(/* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszName);
        
        [PreserveSig]
        new HRESULT GetPropertyType(/* [out] __RPC__out */ out ushort pvartype);
        
        [PreserveSig]
        new HRESULT GetDisplayName(/* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszName);
        
        [PreserveSig]
        new HRESULT GetEditInvitation(/* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszInvite);
        
        [PreserveSig]
        new HRESULT GetTypeFlags(/* [in] */ PROPDESC_TYPE_FLAGS mask, /* [out] __RPC__out */ out PROPDESC_TYPE_FLAGS ppdtFlags);
        
        [PreserveSig]
        new HRESULT GetViewFlags(/* [out] __RPC__out */ out PROPDESC_VIEW_FLAGS ppdvFlags);
        
        [PreserveSig]
        new HRESULT GetDefaultColumnWidth(/* [out] __RPC__out */ out uint pcxChars);
        
        [PreserveSig]
        new HRESULT GetDisplayType(/* [out] __RPC__out */ out PROPDESC_DISPLAYTYPE pdisplaytype);
        
        [PreserveSig]
        new HRESULT GetColumnState(/* [out] __RPC__out */ out uint pcsFlags);
        
        [PreserveSig]
        new HRESULT GetGroupingRange(/* [out] __RPC__out */ out PROPDESC_GROUPING_RANGE pgr);
        
        [PreserveSig]
        new HRESULT GetRelativeDescriptionType(/* [out] __RPC__out */ out PROPDESC_RELATIVEDESCRIPTION_TYPE prdt);
        
        [PreserveSig]
        new HRESULT GetRelativeDescription(/* [in] __RPC__in */ PropVariant propvar1, /* [in] __RPC__in */ PropVariant propvar2, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszDesc1, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszDesc2);
        
        [PreserveSig]
        new HRESULT GetSortDescription(/* [out] __RPC__out */ out PROPDESC_SORTDESCRIPTION psd);
        
        [PreserveSig]
        new HRESULT GetSortDescriptionLabel(/* [in] */ bool fDescending, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszDescription);
        
        [PreserveSig]
        new HRESULT GetAggregationType(/* [out] __RPC__out */ out PROPDESC_AGGREGATION_TYPE paggtype);
        
        [PreserveSig]
        new HRESULT GetConditionType(/* [out] __RPC__out */ out PROPDESC_CONDITION_TYPE pcontype, /* [out] __RPC__out */ out tagCONDITION_OPERATION popDefault);
        
        [PreserveSig]
        new HRESULT GetEnumTypeList(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        new HRESULT CoerceToCanonicalValue(/* [annotation][out][in] _Inout_ */ PropVariant ppropvar);
        
        [PreserveSig]
        new HRESULT FormatForDisplay(/* [in] __RPC__in */ PropVariant propvar, /* [in] */ PROPDESC_FORMAT_FLAGS pdfFlags, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszDisplay);
        
        [PreserveSig]
        new HRESULT IsValueCanonical(/* [in] __RPC__in */ PropVariant propvar);
        
        // IPropertyDescription2
        [PreserveSig]
        HRESULT GetImageReferenceForValue(/* [in] __RPC__in */ PropVariant propvar, /* [string][out] __RPC__deref_out_opt_string */ out IntPtr ppszImageRes);
    }
}
