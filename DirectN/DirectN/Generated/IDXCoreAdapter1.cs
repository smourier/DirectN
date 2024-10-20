// generated from <Windows SDK Path>\um\dxcore_interface.h
using System;
using System.Runtime.InteropServices;
using size_t = System.UInt64;

namespace DirectN
{
    [ComImport, Guid("a0783366-cfa3-43be-9d79-55b2da97c63c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXCoreAdapter1 : IDXCoreAdapter
    {
        // IDXCoreAdapter
        [PreserveSig]
        new void IsValid();
        
        [PreserveSig]
        new void IsAttributeSupported([MarshalAs(UnmanagedType.LPStruct)] Guid attributeGUID);
        
        [PreserveSig]
        new void IsPropertySupported(DXCoreAdapterProperty property);
        
        [PreserveSig]
        new HRESULT GetProperty(DXCoreAdapterProperty property, ulong bufferSize, /* _Out_writes_bytes_(bufferSize) */ IntPtr propertyData);
        
        [PreserveSig]
        new HRESULT GetPropertySize(DXCoreAdapterProperty property, /* _Out_ */ out size_t bufferSize);
        
        [PreserveSig]
        new void IsQueryStateSupported(DXCoreAdapterState property);
        
        [PreserveSig]
        new HRESULT QueryState(DXCoreAdapterState state, ulong inputStateDetailsSize, /* optional(void) */ IntPtr inputStateDetails, ulong outputBufferSize, /* _Out_writes_bytes_(outputBufferSize) */ IntPtr outputBuffer);
        
        [PreserveSig]
        new void IsSetStateSupported(DXCoreAdapterState property);
        
        [PreserveSig]
        new HRESULT SetState(DXCoreAdapterState state, ulong inputStateDetailsSize, /* optional(void) */ IntPtr inputStateDetails, ulong inputDataSize, /* _In_reads_bytes_(inputDataSize) */ IntPtr inputData);
        
        [PreserveSig]
        new HRESULT GetFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvFactory);
        
        // IDXCoreAdapter1
        [PreserveSig]
        HRESULT GetPropertyWithInput(DXCoreAdapterProperty property, ulong inputPropertyDetailsSize, /* optional(void) */ IntPtr inputPropertyDetails, ulong outputBufferSize, /* _Out_writes_bytes_(outputBufferSize) */ IntPtr outputBuffer);
    }
}
