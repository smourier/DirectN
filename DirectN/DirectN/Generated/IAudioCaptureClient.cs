// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c8adbd64-e71e-48a0-a4de-185c395cd317"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioCaptureClient
    {
        [PreserveSig]
        HRESULT GetBuffer(/* [annotation][out] _Outptr_result_buffer_(_Inexpressible_("*pNumFramesToRead * pFormat->nBlockAlign")) */ out IntPtr ppData, /* [annotation][out] _Out_ */ out uint pNumFramesToRead, /* [annotation][out] _Out_ */ out uint pdwFlags, /* optional(UINT64) */ IntPtr pu64DevicePosition, /* optional(UINT64) */ IntPtr pu64QPCPosition);

        [PreserveSig]
        HRESULT ReleaseBuffer(/* [annotation][in] _In_ */ uint NumFramesRead);

        [PreserveSig]
        HRESULT GetNextPacketSize(/* [annotation][out] _Out_ */ out uint pNumFramesInNextPacket);
    }
}
