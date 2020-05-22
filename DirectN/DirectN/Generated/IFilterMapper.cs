// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(4829,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a868a3-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFilterMapper
    {
        [PreserveSig]
        HRESULT RegisterFilter(/* [in] */ Guid clsid, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string Name, /* [in] */ uint dwMerit);
        
        [PreserveSig]
        HRESULT RegisterFilterInstance(/* [in] */ Guid clsid, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string Name, /* [annotation][out] _Out_ */ out Guid MRId);
        
        [PreserveSig]
        HRESULT RegisterPin(/* [in] */ Guid Filter, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string Name, /* [in] */ bool bRendered, /* [in] */ bool bOutput, /* [in] */ bool bZero, /* [in] */ bool bMany, /* [in] */ Guid ConnectsToFilter, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string ConnectsToPin);
        
        [PreserveSig]
        HRESULT RegisterPinType(/* [in] */ Guid clsFilter, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string strName, /* [in] */ Guid clsMajorType, /* [in] */ Guid clsSubType);
        
        [PreserveSig]
        HRESULT UnregisterFilter(/* [in] */ Guid Filter);
        
        [PreserveSig]
        HRESULT UnregisterFilterInstance(/* [in] */ Guid MRId);
        
        [PreserveSig]
        HRESULT UnregisterPin(/* [in] */ Guid Filter, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        [PreserveSig]
        HRESULT EnumMatchingFilters(/* [annotation][out] _Out_ */ out IEnumRegFilters ppEnum, /* [in] */ uint dwMerit, /* [in] */ bool bInputNeeded, /* [in] */ Guid clsInMaj, /* [in] */ Guid clsInSub, /* [in] */ bool bRender, /* [in] */ bool bOututNeeded, /* [in] */ Guid clsOutMaj, /* [in] */ Guid clsOutSub);
    }
}
