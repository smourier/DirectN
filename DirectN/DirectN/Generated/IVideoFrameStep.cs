// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e46a9787-2b71-444d-a4b5-1fab7b708d6a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
