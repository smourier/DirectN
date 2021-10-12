// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(17946,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ef5dc845-f0d9-4ec9-b00c-cb5183d38434"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFProtectedEnvironmentAccess
    {
        [PreserveSig]
        HRESULT Call(/* [annotation] _In_ */ int inputLength, /* [annotation] _In_reads_bytes_(inputLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] input, /* [annotation] _In_ */ int outputLength, /* [annotation] _Out_writes_bytes_(outputLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] output);
        
        [PreserveSig]
        HRESULT ReadGRL(/* [annotation] _Out_ */ out uint outputLength, /* [annotation] _Outptr_result_bytebuffer_(*outputLength) */ out IntPtr output);
    }
}
