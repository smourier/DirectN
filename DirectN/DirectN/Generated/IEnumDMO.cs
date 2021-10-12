// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mediaobj.h(716,5)
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
