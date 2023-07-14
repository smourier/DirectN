// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxvahd.h(750,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("95f4edf4-6e03-4cd7-be1b-3075d665aa52"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXVAHD_VideoProcessor
    {
        [PreserveSig]
        HRESULT SetVideoProcessBltState(/* [annotation][in] _In_ */ _DXVAHD_BLT_STATE State, /* [annotation][in] _In_ */ uint DataSize, /* [annotation][in] _In_reads_bytes_(DataSize) */ IntPtr pData);

        [PreserveSig]
        HRESULT GetVideoProcessBltState(/* [annotation][in] _In_ */ _DXVAHD_BLT_STATE State, /* [annotation][in] _In_ */ uint DataSize, /* [annotation][out] _Inout_updates_bytes_(DataSize) */ out IntPtr pData);

        [PreserveSig]
        HRESULT SetVideoProcessStreamState(/* [annotation][in] _In_ */ uint StreamNumber, /* [annotation][in] _In_ */ _DXVAHD_STREAM_STATE State, /* [annotation][in] _In_ */ uint DataSize, /* [annotation][in] _In_reads_bytes_(DataSize) */ IntPtr pData);

        [PreserveSig]
        HRESULT GetVideoProcessStreamState(/* [annotation][in] _In_ */ uint StreamNumber, /* [annotation][in] _In_ */ _DXVAHD_STREAM_STATE State, /* [annotation][in] _In_ */ uint DataSize, /* [annotation][out] _Inout_updates_bytes_(DataSize) */ out IntPtr pData);

        [PreserveSig]
        HRESULT VideoProcessBltHD(/* [annotation][in] _In_ */ IDirect3DSurface9 pOutputSurface, /* [annotation][in] _In_ */ uint OutputFrame, /* [annotation][in] _In_ */ int StreamCount, /* [annotation][size_is][in] _In_reads_(StreamCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _DXVAHD_STREAM_DATA[] pStreams);
    }
}
