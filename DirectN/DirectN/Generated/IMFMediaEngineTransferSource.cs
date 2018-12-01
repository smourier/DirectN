// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(5898,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("24230452-fe54-40cc-94f3-fcc394c340d6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineTransferSource
    {
        [PreserveSig]
        HRESULT TransferSourceToMediaEngine(/* [annotation][in] _In_ */ IMFMediaEngine destination);
    }
}
