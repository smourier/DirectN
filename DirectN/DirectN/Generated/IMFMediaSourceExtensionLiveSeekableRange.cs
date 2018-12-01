// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(4032,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5d1abfd6-450a-4d92-9efc-d6b6cbc1f4da"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSourceExtensionLiveSeekableRange
    {
        [PreserveSig]
        HRESULT SetLiveSeekableRange(/* [annotation][in] _In_ */ double start, /* [annotation][in] _In_ */ double end);
        
        [PreserveSig]
        HRESULT ClearLiveSeekableRange();
    }
}
