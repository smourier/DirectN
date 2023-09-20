// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9e184d15-cdb7-4f86-b49e-566689f4a601"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineEMENotify
    {
        [PreserveSig]
        void Encrypted(/* [annotation] _In_reads_bytes_opt_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbInitData, /* [annotation] _In_ */ int cb, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string bstrInitDataType);
        
        [PreserveSig]
        void WaitingForKey();
    }
}
