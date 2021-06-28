// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(20832,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("687f6dac-6987-4750-a16a-734d1e7a10fe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFExtendedCameraIntrinsics
    {
        [PreserveSig]
        HRESULT InitializeFromBuffer(/* [annotation][size_is][in] _In_reads_bytes_(dwBufferSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbBuffer, /* [in] */ int dwBufferSize);
        
        [PreserveSig]
        HRESULT GetBufferSize(/* [annotation][out] _Out_ */ out uint pdwBufferSize);
        
        [PreserveSig]
        HRESULT SerializeToBuffer(/* [annotation][out] _Out_writes_bytes_to_(*pdwBufferSize, *pdwBufferSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbBuffer, /* [annotation][out] _Inout_ */ ref int pdwBufferSize);
        
        [PreserveSig]
        HRESULT GetIntrinsicModelCount(/* [annotation][out] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetIntrinsicModelByIndex(/* [in] */ uint dwIndex, /* [annotation][out] _COM_Outptr_ */ out IMFExtendedCameraIntrinsicModel ppIntrinsicModel);
        
        [PreserveSig]
        HRESULT AddIntrinsicModel(/* [annotation][in] _In_ */ IMFExtendedCameraIntrinsicModel pIntrinsicModel);
    }
}
