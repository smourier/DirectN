// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(20679,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("687f6dac-6987-4750-a16a-734d1e7a10fe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFExtendedCameraIntrinsics
    {
        [PreserveSig]
        HRESULT InitializeFromBuffer(/* [annotation][size_is][in] _In_reads_bytes_(dwBufferSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbBuffer, /* [in] */ uint dwBufferSize);
        
        [PreserveSig]
        HRESULT GetBufferSize(/* [annotation][out] _Out_ */ out uint pdwBufferSize);
        
        [PreserveSig]
        HRESULT SerializeToBuffer(/* [annotation][out] _Out_writes_bytes_to_(*pdwBufferSize, *pdwBufferSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbBuffer, /* [annotation][out] _Inout_ */ ref uint pdwBufferSize);
        
        [PreserveSig]
        HRESULT GetIntrinsicModelCount(/* [annotation][out] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetIntrinsicModelByIndex(/* [in] */ uint dwIndex, /* [annotation][out] _COM_Outptr_ */ out IMFExtendedCameraIntrinsicModel ppIntrinsicModel);
        
        [PreserveSig]
        HRESULT AddIntrinsicModel(/* [annotation][in] _In_ */ IMFExtendedCameraIntrinsicModel pIntrinsicModel);
    }
}
