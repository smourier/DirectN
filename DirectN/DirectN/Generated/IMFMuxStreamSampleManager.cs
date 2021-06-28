// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(6421,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("74abbc19-b1cc-4e41-bb8b-9d9b86a8f6ca"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMuxStreamSampleManager
    {
        [PreserveSig]
        HRESULT GetStreamCount(/* [annotation] _Out_ */ out uint pdwMuxStreamCount);
        
        [PreserveSig]
        HRESULT GetSample(/* [annotation] _In_ */ uint dwMuxStreamIndex, /* [annotation] _COM_Outptr_ */ out IMFSample ppSample);
        
        [PreserveSig]
        ulong GetStreamConfiguration();
    }
}
