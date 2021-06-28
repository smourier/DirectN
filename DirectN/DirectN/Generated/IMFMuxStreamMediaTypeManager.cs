// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(6271,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("505a2c72-42f7-4690-aeab-8f513d0ffdb8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMuxStreamMediaTypeManager
    {
        [PreserveSig]
        HRESULT GetStreamCount(/* [annotation] _Out_ */ out uint pdwMuxStreamCount);
        
        [PreserveSig]
        HRESULT GetMediaType(/* [annotation] _In_ */ uint dwMuxStreamIndex, /* [annotation] _COM_Outptr_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT GetStreamConfigurationCount(/* [annotation] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT AddStreamConfiguration(/* [annotation] _In_ */ ulong ullStreamMask);
        
        [PreserveSig]
        HRESULT RemoveStreamConfiguration(/* [annotation] _In_ */ ulong ullStreamMask);
        
        [PreserveSig]
        HRESULT GetStreamConfiguration(/* [annotation] _In_ */ uint ulIndex, /* [annotation] _Out_ */ out ulong pullStreamMask);
    }
}
