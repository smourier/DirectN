// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\audioclient.h(1333,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6f49ff73-6727-49ac-a008-d98cf5e70048"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioClock2
    {
        [PreserveSig]
        HRESULT GetDevicePosition(/* [annotation][out] _Out_ */ out ulong DevicePosition, /* [annotation][unique][out] _Out_opt_ */ out ulong QPCPosition);
    }
}
