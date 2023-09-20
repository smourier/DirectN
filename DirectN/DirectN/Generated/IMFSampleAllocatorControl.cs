// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("da62b958-3a38-4a97-bd27-149c640c0771"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSampleAllocatorControl
    {
        [PreserveSig]
        HRESULT SetDefaultAllocator(/* [annotation][in] _In_ */ uint dwOutputStreamID, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pAllocator);
        
        [PreserveSig]
        HRESULT GetAllocatorUsage(/* [annotation][in] _In_ */ uint dwOutputStreamID, /* [annotation][out] _Out_ */ out uint pdwInputStreamID, /* [annotation][out] _Out_ */ out MFSampleAllocatorUsage peUsage);
    }
}
