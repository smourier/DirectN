// generated from <Windows SDK Path>\um\mfmediacapture.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3de21209-8ba6-4f2a-a577-2819b56ff14d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAdvancedMediaCaptureInitializationSettings
    {
        [PreserveSig]
        HRESULT SetDirectxDeviceManager(/* [in] */ IMFDXGIDeviceManager value);
    }
}
