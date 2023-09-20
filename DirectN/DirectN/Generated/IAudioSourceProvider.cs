// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ebbaf249-afc2-4582-91c6-b60df2e84954"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSourceProvider
    {
        [PreserveSig]
        HRESULT ProvideInput(/* [annotation][in] _In_ */ uint dwSampleCount, /* [annotation][in] _Inout_ */ ref uint pdwChannelCount, /* [annotation][out] _Out_writes_opt_(dwSampleCount * (*pdwChannelCount)) */ [Out, MarshalAs(UnmanagedType.LPArray)] float[] pInterleavedAudioData);
    }
}
