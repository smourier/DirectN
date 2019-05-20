// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfmediaengine.h(8603,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e9707e05-6d55-4636-b185-3de21210bd75"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaKeySession2 : IMFMediaKeySession
    {
        // IMFMediaKeySession
        [PreserveSig]
        new HRESULT GetError(/* [annotation] _Out_ */ out ushort code, /* [annotation] _Out_ */ out uint systemCode);
        
        [PreserveSig]
        new HRESULT get_KeySystem(/* [annotation] _COM_Outptr_ */ out IntPtr keySystem);
        
        [PreserveSig]
        new HRESULT get_SessionId(/* [annotation] _COM_Outptr_ */ out IntPtr sessionId);
        
        [PreserveSig]
        new HRESULT Update(/* [annotation] _In_reads_bytes_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] key, /* [annotation] _In_ */ uint cb);
        
        [PreserveSig]
        new HRESULT Close();
        
        // IMFMediaKeySession2
        [PreserveSig]
        HRESULT get_KeyStatuses(/* [annotation] _Outptr_result_buffer_(*puSize) */ out IntPtr pKeyStatusesArray, /* [annotation] _Out_ */ out uint puSize);
        
        [PreserveSig]
        HRESULT Load(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string bstrSessionId, /* [annotation] _Out_ */ out bool pfLoaded);
        
        [PreserveSig]
        HRESULT GenerateRequest(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string initDataType, /* [annotation] _In_reads_bytes_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbInitData, /* [annotation] _In_ */ uint cb);
        
        [PreserveSig]
        HRESULT get_Expiration(/* [annotation] _Out_ */ out double dblExpiration);
        
        [PreserveSig]
        HRESULT Remove();
        
        [PreserveSig]
        HRESULT Shutdown();
    }
}
