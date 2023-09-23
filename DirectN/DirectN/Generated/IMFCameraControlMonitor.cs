// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4d46f2c9-28ba-4970-8c7b-1f0c9d80af69"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCameraControlMonitor
    {
        [PreserveSig]
        HRESULT Start();
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT AddControlSubscription(/* [annotation][in] _In_ */ Guid controlSet, /* [annotation][in] _In_ */ uint id);
        
        [PreserveSig]
        HRESULT RemoveControlSubscription(/* [annotation][in] _In_ */ Guid controlSet, /* [annotation][in] _In_ */ uint id);
        
        [PreserveSig]
        void Shutdown();
    }
}
