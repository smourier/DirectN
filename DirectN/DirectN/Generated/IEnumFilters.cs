// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a86893-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEnumFilters
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint cFilters, /* [annotation][out] _Out_writes_to_(cFilters, *pcFetched) */ IntPtr ppFilter, /* optional(ULONG) */ IntPtr pcFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint cFilters);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [annotation][out] _Out_ */ out IEnumFilters ppEnum);
    }
}
