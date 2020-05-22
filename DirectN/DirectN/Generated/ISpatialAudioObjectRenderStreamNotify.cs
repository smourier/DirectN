// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\spatialaudioclient.h(808,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dddf83e6-68d7-4c70-883f-a1836afb4a50"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObjectRenderStreamNotify
    {
        [PreserveSig]
        HRESULT OnAvailableDynamicObjectCountChange(/* [annotation][in] _In_ */ ISpatialAudioObjectRenderStreamBase sender, /* [annotation][in] _In_ */ long hnsComplianceDeadlineTime, /* [annotation][in] _In_ */ uint availableDynamicObjectCountChange);
    }
}
