// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(4792,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6a0083f9-8947-4c1d-9ce0-cdee22b23135"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaKeySessionNotify
    {
        [PreserveSig]
        void KeyMessage(/* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string destinationURL, /* [annotation] _In_reads_bytes_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] message, /* [annotation] _In_ */ int cb);
        
        [PreserveSig]
        void KeyAdded();
        
        [PreserveSig]
        void KeyError(/* [annotation] _In_ */ ushort code, /* [annotation] _In_ */ uint systemCode);
    }
}
