// generated from <Windows SDK Path>\um\spatialaudioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dddf83e6-68d7-4c70-883f-a1836afb4a50"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioObjectRenderStreamNotify
    {
        [PreserveSig]
        HRESULT OnAvailableDynamicObjectCountChange(/* [annotation][in] _In_ */ ISpatialAudioObjectRenderStreamBase sender, /* [annotation][in] _In_ */ long hnsComplianceDeadlineTime, /* [annotation][in] _In_ */ uint availableDynamicObjectCountChange);
    }
}
