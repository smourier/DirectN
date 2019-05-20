// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(3278,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("68961e68-832b-41ea-bc91-63593f3e70e3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaSample2Config
    {
        [PreserveSig]
        HRESULT GetSurface(/* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppDirect3DSurface9);
    }
}
