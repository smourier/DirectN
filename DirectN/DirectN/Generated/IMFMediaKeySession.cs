// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("24fa67d5-d1d0-4dc5-995c-c0efdc191fb5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaKeySession
    {
        [PreserveSig]
        HRESULT GetError(/* [annotation] _Out_ */ out ushort code, /* [annotation] _Out_ */ out uint systemCode);
        
        [PreserveSig]
        HRESULT get_KeySystem(/* [annotation] _COM_Outptr_ */ out IntPtr keySystem);
        
        [PreserveSig]
        HRESULT get_SessionId(/* [annotation] _COM_Outptr_ */ out IntPtr sessionId);
        
        [PreserveSig]
        HRESULT Update(/* [annotation] _In_reads_bytes_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] key, /* [annotation] _In_ */ int cb);
        
        [PreserveSig]
        HRESULT Close();
    }
}
