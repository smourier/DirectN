// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4d645ace-26aa-4688-9be1-df3516990b93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineClassFactory
    {
        [PreserveSig]
        HRESULT CreateInstance(/* [annotation][in] _In_ */ uint dwFlags, /* [annotation][in] _In_ */ IMFAttributes pAttr, /* [annotation][out] _Outptr_ */ out IMFMediaEngine ppPlayer);
        
        [PreserveSig]
        HRESULT CreateTimeRange(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppTimeRange);
        
        [PreserveSig]
        HRESULT CreateError(/* [annotation][out] _Outptr_ */ out IMFMediaError ppError);
    }
}
