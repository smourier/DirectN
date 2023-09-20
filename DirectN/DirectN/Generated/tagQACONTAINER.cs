// generated from <Windows SDK Path>\um\ocidl.h
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
