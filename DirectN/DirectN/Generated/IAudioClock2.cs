// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6f49ff73-6727-49ac-a008-d98cf5e70048"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioClock2
    {
        [PreserveSig]
        HRESULT GetDevicePosition(/* [annotation][out] _Out_ */ out ulong DevicePosition, /* optional(UINT64) */ IntPtr QPCPosition);
    }
}
