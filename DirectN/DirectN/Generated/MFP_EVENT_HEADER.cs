// generated from <Windows SDK Path>\um\mfplay.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MFP_EVENT_HEADER
    {
        public MFP_EVENT_TYPE eEventType;
        public HRESULT hrEvent;
        public IntPtr pMediaPlayer;
        public MFP_MEDIAPLAYER_STATE eState;
        public IntPtr pPropertyStore;
    }
}
