// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(1617,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("89c31040-846b-11ce-97d3-00aa0055595a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEnumMediaTypes
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint cMediaTypes, /* [annotation][size_is][out] _Out_writes_to_(cMediaTypes, *pcFetched) */ out IntPtr ppMediaTypes, /* optional(ULONG) */ IntPtr pcFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint cMediaTypes);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [annotation][out] _Out_ */ out IEnumMediaTypes ppEnum);
    }
}
