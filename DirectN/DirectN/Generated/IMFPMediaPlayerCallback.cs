// generated from <Windows SDK Path>\um\mfplay.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("766c8ffb-5fdb-4fea-a28d-b912996f51bd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMediaPlayerCallback
    {
        [PreserveSig]
        void OnMediaPlayerEvent(/* [annotation][in] _In_ */ ref MFP_EVENT_HEADER pEventHeader);
    }
}
