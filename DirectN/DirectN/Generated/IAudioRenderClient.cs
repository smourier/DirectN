// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f294acfc-3146-4483-a7bf-addca7c260e2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioRenderClient
    {
        [PreserveSig]
        HRESULT GetBuffer(/* [annotation][in] _In_ */ uint NumFramesRequested, /* [annotation][out] _Outptr_result_buffer_(_Inexpressible_("NumFramesRequested * pFormat->nBlockAlign")) */ out IntPtr ppData);
        
        [PreserveSig]
        HRESULT ReleaseBuffer(/* [annotation][in] _In_ */ uint NumFramesWritten, /* [annotation][in] _In_ */ uint dwFlags);
    }
}
