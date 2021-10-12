// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(8869,5)
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
