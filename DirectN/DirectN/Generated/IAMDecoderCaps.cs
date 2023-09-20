// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c0dff467-d499-4986-972b-e1d9090fa941"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMDecoderCaps
    {
        [PreserveSig]
        HRESULT GetDecoderCaps(/* [in] */ uint dwCapIndex, /* [annotation][out] _Out_ */ out uint lpdwCap);
    }
}
