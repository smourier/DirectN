// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(1009,9)
using System;
using System.Runtime.InteropServices;
using PDXVAHDSW_CreateDevice = System.IntPtr;
using PDXVAHDSW_CreateVideoProcessor = System.IntPtr;
using PDXVAHDSW_DestroyDevice = System.IntPtr;
using PDXVAHDSW_DestroyVideoProcessor = System.IntPtr;
using PDXVAHDSW_GetVideoProcessBltStatePrivate = System.IntPtr;
using PDXVAHDSW_GetVideoProcessorCaps = System.IntPtr;
using PDXVAHDSW_GetVideoProcessorCustomRates = System.IntPtr;
using PDXVAHDSW_GetVideoProcessorDeviceCaps = System.IntPtr;
using PDXVAHDSW_GetVideoProcessorFilterRange = System.IntPtr;
using PDXVAHDSW_GetVideoProcessorInputFormats = System.IntPtr;
using PDXVAHDSW_GetVideoProcessorOutputFormats = System.IntPtr;
using PDXVAHDSW_GetVideoProcessStreamStatePrivate = System.IntPtr;
using PDXVAHDSW_ProposeVideoPrivateFormat = System.IntPtr;
using PDXVAHDSW_SetVideoProcessBltState = System.IntPtr;
using PDXVAHDSW_SetVideoProcessStreamState = System.IntPtr;
using PDXVAHDSW_VideoProcessBltHD = System.IntPtr;

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
