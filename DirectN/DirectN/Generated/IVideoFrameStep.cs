// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(14921,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e46a9787-2b71-444d-a4b5-1fab7b708d6a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVideoFrameStep
    {
        [PreserveSig]
        HRESULT Step(uint dwFrames, /* [annotation][unique] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pStepObject);
        
        [PreserveSig]
        HRESULT CanStep(int bMultiple, /* [annotation][unique] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pStepObject);
        
        [PreserveSig]
        HRESULT CancelStep();
    }
}
