// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\strmif.h(18524,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cf7b26fc-9a00-485b-8147-3e789d5e8f67"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMAsyncReaderTimestampScaling
    {
        [PreserveSig]
        HRESULT GetTimestampMode(/* [annotation] _Out_ */ out bool pfRaw);
        
        [PreserveSig]
        HRESULT SetTimestampMode(bool fRaw);
    }
}
