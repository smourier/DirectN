// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a624f617-4704-4206-8a6d-ebda4a093985"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCameraConfigurationManager
    {
        [PreserveSig]
        HRESULT LoadDefaults(/* [annotation][in] _In_ */ IMFAttributes cameraAttributes, /* [annotation][out] _COM_Outptr_ */ out IMFCameraControlDefaultsCollection configurations);
        
        [PreserveSig]
        HRESULT SaveDefaults(/* [annotation][in] _In_ */ IMFCameraControlDefaultsCollection configurations);
        
        [PreserveSig]
        void Shutdown();
    }
}
