// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mediaobj.h(1054,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("be8f4f4e-5b16-4d29-b350-7f6b5d9298ac"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDMOVideoOutputOptimizations
    {
        [PreserveSig]
        HRESULT QueryOperationModePreferences(uint ulOutputStreamIndex, /* [annotation] _Out_ */ out uint pdwRequestedCapabilities);
        
        [PreserveSig]
        HRESULT SetOperationMode(uint ulOutputStreamIndex, uint dwEnabledFeatures);
        
        [PreserveSig]
        HRESULT GetCurrentOperationMode(uint ulOutputStreamIndex, /* [annotation] _Out_ */ out uint pdwEnabledFeatures);
        
        [PreserveSig]
        HRESULT GetCurrentSampleRequirements(uint ulOutputStreamIndex, /* [annotation] _Out_ */ out uint pdwRequestedFeatures);
    }
}
