// generated from <Windows SDK Path>\um\mfobjects.h
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
