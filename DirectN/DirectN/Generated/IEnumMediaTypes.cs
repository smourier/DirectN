// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("89c31040-846b-11ce-97d3-00aa0055595a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEnumMediaTypes
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint cMediaTypes, /* [annotation][size_is][out] _Out_writes_to_(cMediaTypes, *pcFetched) */ IntPtr ppMediaTypes, /* optional(ULONG) */ IntPtr pcFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint cMediaTypes);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [annotation][out] _Out_ */ out IEnumMediaTypes ppEnum);
    }
}
