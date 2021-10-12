// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(800,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fee7c112-e776-42b5-9bbf-0048524e2bd5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineNotify
    {
        [PreserveSig]
        HRESULT EventNotify(/* [annotation][in] _In_ */ uint @event, /* [annotation][in] _In_ */ IntPtr param1, /* [annotation][in] _In_ */ uint param2);
    }
}
