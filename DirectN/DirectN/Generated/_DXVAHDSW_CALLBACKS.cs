// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(1009,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDSW_CALLBACKS
    {
        public IntPtr CreateDevice;
        public IntPtr ProposeVideoPrivateFormat;
        public IntPtr GetVideoProcessorDeviceCaps;
        public IntPtr GetVideoProcessorOutputFormats;
        public IntPtr GetVideoProcessorInputFormats;
        public IntPtr GetVideoProcessorCaps;
        public IntPtr GetVideoProcessorCustomRates;
        public IntPtr GetVideoProcessorFilterRange;
        public IntPtr DestroyDevice;
        public IntPtr CreateVideoProcessor;
        public IntPtr SetVideoProcessBltState;
        public IntPtr GetVideoProcessBltStatePrivate;
        public IntPtr SetVideoProcessStreamState;
        public IntPtr GetVideoProcessStreamStatePrivate;
        public IntPtr VideoProcessBltHD;
        public IntPtr DestroyVideoProcessor;
    }
}
