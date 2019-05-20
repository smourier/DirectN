// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ocidl.h(6479,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagQACONTAINER
    {
        public uint cbSize;
        public IntPtr pClientSite;
        public IntPtr pAdviseSink;
        public IntPtr pPropertyNotifySink;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pUnkEventSink;
        public uint dwAmbientFlags;
        public uint colorFore;
        public uint colorBack;
        public IntPtr pFont;
        public IntPtr pUndoMgr;
        public uint dwAppearance;
        public int lcid;
        public IntPtr hpal;
        public IntPtr pBindHost;
        public IntPtr pOleControlSite;
        public IntPtr pServiceProvider;
    }
}
