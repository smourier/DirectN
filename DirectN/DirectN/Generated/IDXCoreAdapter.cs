// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxcore_interface.h(101,1)
using System;
using System.Runtime.InteropServices;
using size_t = System.UInt64;

namespace DirectN
{
    [ComImport, Guid("f0db4c7f-fe5a-42a2-bd62-f2a6cf6fc83e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXCoreAdapter
    {
        [PreserveSig]
        void IsValid();
        
        [PreserveSig]
        void IsAttributeSupported([MarshalAs(UnmanagedType.LPStruct)] Guid attributeGUID);
        
        [PreserveSig]
        void IsPropertySupported(DXCoreAdapterProperty property);
        
        [PreserveSig]
        HRESULT GetProperty(DXCoreAdapterProperty property, ulong bufferSize, /* _Out_writes_bytes_(bufferSize) */ IntPtr propertyData);
        
        [PreserveSig]
        HRESULT GetPropertySize(DXCoreAdapterProperty property, /* _Out_ */ out size_t bufferSize);
        
        [PreserveSig]
        void IsQueryStateSupported(DXCoreAdapterState property);
        
        [PreserveSig]
        HRESULT QueryState(DXCoreAdapterState state, ulong inputStateDetailsSize, /* optional(void) */ IntPtr inputStateDetails, ulong outputBufferSize, /* _Out_writes_bytes_(outputBufferSize) */ IntPtr outputBuffer);
        
        [PreserveSig]
        void IsSetStateSupported(DXCoreAdapterState property);
        
        [PreserveSig]
        HRESULT SetState(DXCoreAdapterState state, ulong inputStateDetailsSize, /* optional(void) */ IntPtr inputStateDetails, ulong inputDataSize, /* _In_reads_bytes_(inputDataSize) */ IntPtr inputData);
        
        [PreserveSig]
        HRESULT GetFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvFactory);
    }
}
