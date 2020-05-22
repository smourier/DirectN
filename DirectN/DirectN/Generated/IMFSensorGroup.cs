// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(18924,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4110243a-9757-461f-89f1-f22345bcab4e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorGroup
    {
        [PreserveSig]
        HRESULT GetSymbolicLink(/* [annotation][size_is][out] _Out_writes_z_(cchSymbolicLink) */ [MarshalAs(UnmanagedType.LPWStr)] string SymbolicLink, /* [annotation][in] _In_ */ int cchSymbolicLink, /* [annotation][out] _Out_ */ out int pcchWritten);
        
        [PreserveSig]
        HRESULT GetFlags(/* [annotation][out] _Out_ */ out ulong pFlags);
        
        [PreserveSig]
        HRESULT GetSensorGroupAttributes(/* [annotation][out] _COM_Outptr_result_maybenull_ */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        HRESULT GetSensorDeviceCount(/* [annotation][out] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetSensorDevice(/* [annotation][in] _In_ */ uint dwIndex, /* [annotation][out] _COM_Outptr_ */ out IMFSensorDevice ppDevice);
        
        [PreserveSig]
        HRESULT SetDefaultSensorDeviceIndex(/* [annotation][in] _In_ */ uint dwIndex);
        
        [PreserveSig]
        HRESULT GetDefaultSensorDeviceIndex(/* [annotation][out] _Out_ */ out uint pdwIndex);
        
        [PreserveSig]
        HRESULT CreateMediaSource(/* [annotation][out] _COM_Outptr_ */ out IMFMediaSource ppSource);
    }
}
