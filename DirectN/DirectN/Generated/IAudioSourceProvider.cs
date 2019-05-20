// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfmediaengine.h(2895,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ebbaf249-afc2-4582-91c6-b60df2e84954"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSourceProvider
    {
        [PreserveSig]
        HRESULT ProvideInput(/* [annotation][in] _In_ */ uint dwSampleCount, /* [annotation][in] _Inout_ */ ref uint pdwChannelCount, /* [annotation][out] _Out_writes_opt_(dwSampleCount * (*pdwChannelCount)) */ [Out, MarshalAs(UnmanagedType.LPArray)] float[] pInterleavedAudioData);
    }
}
