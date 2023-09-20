// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("22320cb2-d41a-11d2-bf7c-d7cb9df0bf93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMAudioRendererStats
    {
        [PreserveSig]
        HRESULT GetStatParam(/* [in] */ uint dwParam, /* [annotation][out] _Out_ */ out uint pdwParam1, /* [annotation][out] _Out_ */ out uint pdwParam2);
    }
}
