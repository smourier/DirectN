// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audioenginebaseapo.h(365,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7ba1db8f-78ad-49cd-9591-f79d80a17c81"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObjectVBR
    {
        [PreserveSig]
        HRESULT CalcMaxInputFrames(/* [in] */ uint u32MaxOutputFrameCount, /* [out] __RPC__out */ out uint pu32InputFrameCount);
        
        [PreserveSig]
        HRESULT CalcMaxOutputFrames(/* [in] */ uint u32MaxInputFrameCount, /* [out] __RPC__out */ out uint pu32OutputFrameCount);
    }
}
