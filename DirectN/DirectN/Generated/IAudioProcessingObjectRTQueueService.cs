// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("acd65e2f-955b-4b57-b9bf-ac297bb752c9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObjectRTQueueService
    {
        [PreserveSig]
        HRESULT GetRealTimeWorkQueue(/* [annotation][out] _Out_ */ out uint workQueueId);
    }
}
