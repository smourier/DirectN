// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(6173,5)
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
