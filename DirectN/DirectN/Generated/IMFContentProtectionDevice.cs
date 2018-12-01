// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(17209,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e6257174-a060-4c9a-a088-3b1b471cad28"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentProtectionDevice
    {
        [PreserveSig]
        HRESULT InvokeFunction(/* [annotation][in] _In_ */ uint FunctionId, /* [annotation][in] _In_ */ uint InputBufferByteCount, /* [annotation][size_is][in] _In_reads_bytes_(InputBufferByteCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] InputBuffer, /* [annotation][out][in] _Inout_ */ ref uint OutputBufferByteCount, /* [annotation][size_is][out] _Out_writes_bytes_(*OutputBufferByteCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] OutputBuffer);
        
        [PreserveSig]
        HRESULT GetPrivateDataByteCount(/* [annotation][out] _Out_ */ out uint PrivateInputByteCount, /* [annotation][out] _Out_ */ out uint PrivateOutputByteCount);
    }
}
