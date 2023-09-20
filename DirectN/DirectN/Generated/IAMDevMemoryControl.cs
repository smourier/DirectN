// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c6545bf1-e76b-11d0-bd52-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMDevMemoryControl
    {
        [PreserveSig]
        HRESULT QueryWriteSync();
        
        [PreserveSig]
        HRESULT WriteSync();
        
        [PreserveSig]
        HRESULT GetDevId(/* [annotation][out] _Out_ */ out uint pdwDevId);
    }
}
