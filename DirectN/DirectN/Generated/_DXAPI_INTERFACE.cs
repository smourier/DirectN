// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxmini.h(328,9)
using System;
using System.Runtime.InteropServices;
using PDX_BOBNEXTFIELD = System.IntPtr;
using PDX_ENABLEIRQ = System.IntPtr;
using PDX_FLIPOVERLAY = System.IntPtr;
using PDX_FLIPVIDEOPORT = System.IntPtr;
using PDX_GETCURRENTAUTOFLIP = System.IntPtr;
using PDX_GETIRQINFO = System.IntPtr;
using PDX_GETPOLARITY = System.IntPtr;
using PDX_GETPREVIOUSAUTOFLIP = System.IntPtr;
using PDX_GETTRANSFERSTATUS = System.IntPtr;
using PDX_LOCK = System.IntPtr;
using PDX_SETSTATE = System.IntPtr;
using PDX_SKIPNEXTFIELD = System.IntPtr;
using PDX_TRANSFER = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXAPI_INTERFACE
    {
        public ushort Size;
        public ushort Version;
        public IntPtr Context;
        public IntPtr InterfaceReference;
        public IntPtr InterfaceDereference;
        public IntPtr DxGetIrqInfo;
        public IntPtr DxEnableIrq;
        public IntPtr DxSkipNextField;
        public IntPtr DxBobNextField;
        public IntPtr DxSetState;
        public IntPtr DxLock;
        public IntPtr DxFlipOverlay;
        public IntPtr DxFlipVideoPort;
        public IntPtr DxGetPolarity;
        public IntPtr DxGetCurrentAutoflip;
        public IntPtr DxGetPreviousAutoflip;
        public IntPtr DxTransfer;
        public IntPtr DxGetTransferStatus;
    }
}
