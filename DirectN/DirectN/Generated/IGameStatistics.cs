// generated from <Windows SDK Path>\um\gameux.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3887c9ca-04a0-42ae-bc4c-5fa6c7721145"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGameStatistics
    {
        [PreserveSig]
        HRESULT GetMaxCategoryLength(/* [retval][out] __RPC__out */ out uint cch);
        
        [PreserveSig]
        HRESULT GetMaxNameLength(/* [retval][out] __RPC__out */ out uint cch);
        
        [PreserveSig]
        HRESULT GetMaxValueLength(/* [retval][out] __RPC__out */ out uint cch);
        
        [PreserveSig]
        HRESULT GetMaxCategories(/* [retval][out] __RPC__out */ out ushort pMax);
        
        [PreserveSig]
        HRESULT GetMaxStatsPerCategory(/* [retval][out] __RPC__out */ out ushort pMax);
        
        [PreserveSig]
        HRESULT SetCategoryTitle(/* [in] */ ushort categoryIndex, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string title);
        
        [PreserveSig]
        HRESULT GetCategoryTitle(/* [in] */ ushort categoryIndex, /* [retval][string][out] __RPC__deref_out_opt_string */ out IntPtr pTitle);
        
        [PreserveSig]
        HRESULT GetStatistic(/* [in] */ ushort categoryIndex, /* [in] */ ushort statIndex, /* optional(LPWSTR) */ out IntPtr pName, /* optional(LPWSTR) */ out IntPtr pValue);
        
        [PreserveSig]
        HRESULT SetStatistic(/* [in] */ ushort categoryIndex, /* [in] */ ushort statIndex, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string name, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string value);
        
        [PreserveSig]
        HRESULT Save(/* [in] */ bool trackChanges);
        
        [PreserveSig]
        HRESULT SetLastPlayedCategory(/* [in] */ uint categoryIndex);
        
        [PreserveSig]
        HRESULT GetLastPlayedCategory(/* [retval][out] __RPC__out */ out uint pCategoryIndex);
    }
}
