// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(21056,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("39dc7f4a-b141-4719-813c-a7f46162a2b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorProcessActivity
    {
        [PreserveSig]
        HRESULT GetProcessId(/* [annotation][out] _Out_ */ out uint pPID);
        
        [PreserveSig]
        HRESULT GetStreamingState(/* [annotation][out] _Out_ */ out bool pfStreaming);
        
        [PreserveSig]
        HRESULT GetStreamingMode(/* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_mfidl_0000_0110_0003 pMode);
        
        [PreserveSig]
        HRESULT GetReportTime(/* [annotation][out] _Out_ */ out long pft);
    }
}
