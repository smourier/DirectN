// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(5275,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("b79bb0b1-33c1-11d1-abe1-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFilterMapper3 : IFilterMapper2
    {
        // IFilterMapper2
        [PreserveSig]
        new HRESULT CreateCategory(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsidCategory, /* [in] */ uint dwCategoryMerit, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string Description);
        
        [PreserveSig]
        new HRESULT UnregisterFilter(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pclsidCategory, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string szInstance, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Filter);
        
        [PreserveSig]
        new HRESULT RegisterFilter(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsidFilter, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string Name, /* [annotation][out][in] _Inout_opt_ */ out IMoniker ppMoniker, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pclsidCategory, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szInstance, /* [in] */ ref REGFILTER2 prf2);
        
        [PreserveSig]
        new HRESULT EnumMatchingFilters(/* [annotation][out] _Out_ */ out IEnumMoniker ppEnum, /* [in] */ uint dwFlags, /* [in] */ bool bExactMatch, /* [in] */ uint dwMerit, /* [in] */ bool bInputNeeded, /* [in] */ uint cInputTypes, /* optional(GUID) */ IntPtr pInputTypes, /* optional(REGPINMEDIUM) */ IntPtr pMedIn, /* optional(CLSID) */ IntPtr pPinCategoryIn, /* [in] */ bool bRender, /* [in] */ bool bOutputNeeded, /* [in] */ uint cOutputTypes, /* optional(GUID) */ IntPtr pOutputTypes, /* optional(REGPINMEDIUM) */ IntPtr pMedOut, /* optional(CLSID) */ IntPtr pPinCategoryOut);
        
        // IFilterMapper3
        [PreserveSig]
        HRESULT GetICreateDevEnum(/* [annotation][out] _Out_ */ out ICreateDevEnum ppEnum);
    }
}
