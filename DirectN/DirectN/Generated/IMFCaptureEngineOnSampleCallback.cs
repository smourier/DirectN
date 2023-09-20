// generated from <Windows SDK Path>\um\mfcaptureengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("52150b82-ab39-4467-980f-e48bf0822ecd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureEngineOnSampleCallback
    {
        [PreserveSig]
        HRESULT OnSample(/* [annotation][in] _In_opt_ */ IMFSample pSample);
    }
}
