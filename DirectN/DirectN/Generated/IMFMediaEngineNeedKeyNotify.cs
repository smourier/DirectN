// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(4415,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("46a30204-a696-4b18-8804-246b8f031bb1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineNeedKeyNotify
    {
        [PreserveSig]
        void NeedKey(/* [annotation] _In_reads_bytes_opt_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] initData, /* [annotation] _In_ */ int cb);
    }
}
