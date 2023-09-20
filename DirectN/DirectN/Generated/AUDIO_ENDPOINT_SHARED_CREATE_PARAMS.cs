// generated from <Windows SDK Path>\um\audioengineendpoint.h
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
