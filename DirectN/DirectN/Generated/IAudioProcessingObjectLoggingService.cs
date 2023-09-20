// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("698f0107-1745-4708-95a5-d84478a62a65"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObjectLoggingService
    {
        [PreserveSig]
        void ApoLog(/* [in] */ APO_LOG_LEVEL level, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string format);
    }
}
