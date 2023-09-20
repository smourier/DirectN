// generated from <Windows SDK Path>\um\mfobjects.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ce8bd576-e440-43b3-be34-1e53f565f7e8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMuxStreamAttributesManager
    {
        [PreserveSig]
        HRESULT GetStreamCount(/* [annotation] _Out_ */ out uint pdwMuxStreamCount);
        
        [PreserveSig]
        HRESULT GetAttributes(/* [annotation] _In_ */ uint dwMuxStreamIndex, /* [annotation] _COM_Outptr_ */ out IMFAttributes ppStreamAttributes);
    }
}
