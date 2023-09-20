// generated from <Windows SDK Path>\um\mediaobj.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2c3cd98a-2bfa-4a53-9c27-5249ba64ba0f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEnumDMO
    {
        [PreserveSig]
        HRESULT Next(int cItemsToFetch, /* [annotation][length_is][size_is][out] _Out_writes_to_(cItemsToFetch, *pcItemsFetched) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] pCLSID, /* [annotation][string][length_is][size_is][out] _Out_writes_to_(cItemsToFetch, *pcItemsFetched) */ IntPtr Names, /* [annotation][out] _Out_ */ out uint pcItemsFetched);
        
        [PreserveSig]
        HRESULT Skip(uint cItemsToSkip);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [annotation][out] _Out_ */ out IEnumDMO ppEnum);
    }
}
