// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audioengineendpoint.h(155,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_ENDPOINT_SHARED_CREATE_PARAMS
    {
        public uint u32Size;
        public uint u32TSSessionId;
        public __MIDL___MIDL_itf_audioengineendpoint_0000_0000_0001 targetEndpointConnectorType;
        public tWAVEFORMATEX wfxDeviceFormat;
    }
}
