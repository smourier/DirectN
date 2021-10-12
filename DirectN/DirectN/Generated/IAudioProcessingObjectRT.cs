// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioenginebaseapo.h(281,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9e1d6a6d-ddbc-4e95-a4c7-ad64ba37846c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObjectRT
    {
        [PreserveSig]
        void APOProcess(/* [annotation][in] _In_ */ uint u32NumInputConnections, /* [annotation][in] _In_ */ ref APO_CONNECTION_PROPERTY ppInputConnections, /* [annotation][in] _In_ */ uint u32NumOutputConnections, /* [annotation][out][in] _Inout_ */ out APO_CONNECTION_PROPERTY ppOutputConnections);
        
        [PreserveSig]
        uint CalcInputFrames(/* [in] */ uint u32OutputFrameCount);
        
        [PreserveSig]
        uint CalcOutputFrames(/* [annotation][in] _In_ */ uint u32InputFrameCount);
    }
}
