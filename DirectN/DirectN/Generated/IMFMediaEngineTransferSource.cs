// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(6267,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("24230452-fe54-40cc-94f3-fcc394c340d6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineTransferSource
    {
        [PreserveSig]
        HRESULT TransferSourceToMediaEngine(/* [annotation][in] _In_ */ IMFMediaEngine destination);
    }
}
