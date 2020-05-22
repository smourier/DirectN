// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(8091,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c3a9e92a-da88-46b0-a110-6cf953026cb9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaKeySessionNotify2 : IMFMediaKeySessionNotify
    {
        // IMFMediaKeySessionNotify
        [PreserveSig]
        new void KeyMessage(/* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string destinationURL, /* [annotation] _In_reads_bytes_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] message, /* [annotation] _In_ */ int cb);
        
        [PreserveSig]
        new void KeyAdded();
        
        [PreserveSig]
        new void KeyError(/* [annotation] _In_ */ ushort code, /* [annotation] _In_ */ uint systemCode);
        
        // IMFMediaKeySessionNotify2
        [PreserveSig]
        void KeyMessage2(/* [annotation] _In_ */ MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string destinationURL, /* [annotation] _In_reads_bytes_(cbMessage) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] pbMessage, /* [annotation] _In_ */ int cbMessage);
        
        [PreserveSig]
        void KeyStatusChange();
    }
}
