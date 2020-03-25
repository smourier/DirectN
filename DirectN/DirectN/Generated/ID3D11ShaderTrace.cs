// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11shadertracing.h(271,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("36b013e6-2811-4845-baa7-d623fe0df104"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ShaderTrace
    {
        [PreserveSig]
        HRESULT TraceReady(/* optional(UINT64) */ IntPtr pTestCount);
        
        [PreserveSig]
        void ResetTrace();
        
        [PreserveSig]
        HRESULT GetTraceStats(/* [annotation] _Out_ */ out D3D11_TRACE_STATS pTraceStats);
        
        [PreserveSig]
        HRESULT PSSelectStamp(/* [annotation] _In_ */ uint stampIndex);
        
        [PreserveSig]
        HRESULT GetInitialRegisterContents(/* [annotation] _In_ */ ref D3D11_TRACE_REGISTER pRegister, /* [annotation] _Out_ */ out D3D11_TRACE_VALUE pValue);
        
        [PreserveSig]
        HRESULT GetStep(/* [annotation] _In_ */ uint stepIndex, /* [annotation] _Out_ */ out D3D11_TRACE_STEP pTraceStep);
        
        [PreserveSig]
        HRESULT GetWrittenRegister(/* [annotation] _In_ */ uint stepIndex, /* [annotation] _In_ */ uint writtenRegisterIndex, /* [annotation] _Out_ */ out D3D11_TRACE_REGISTER pRegister, /* [annotation] _Out_ */ out D3D11_TRACE_VALUE pValue);
        
        [PreserveSig]
        HRESULT GetReadRegister(/* [annotation] _In_ */ uint stepIndex, /* [annotation] _In_ */ uint readRegisterIndex, /* [annotation] _Out_ */ out D3D11_TRACE_REGISTER pRegister, /* [annotation] _Out_ */ out D3D11_TRACE_VALUE pValue);
    }
}
