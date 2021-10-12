// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineextensionapo.h(371,5)
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
