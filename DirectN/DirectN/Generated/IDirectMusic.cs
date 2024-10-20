// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTMUSICBUFFER = DirectN.IDirectMusicBuffer;
using LPDIRECTMUSICPORT = DirectN.IDirectMusicPort;
using LPDIRECTSOUND = DirectN.IDirectSound;
using LPDMUS_BUFFERDESC = DirectN._DMUS_BUFFERDESC;
using LPUNKNOWN = System.Object;

namespace DirectN
{
    [ComImport, Guid("6536115a-7b2d-11d2-ba18-0000f875ac12"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusic
    {
        [PreserveSig]
        HRESULT EnumPort(uint dwIndex, ref _DMUS_PORTCAPS pPortCaps);
        
        [PreserveSig]
        HRESULT CreateMusicBuffer(ref LPDMUS_BUFFERDESC pBufferDesc, out LPDIRECTMUSICBUFFER ppBuffer, LPUNKNOWN pUnkOuter);
        
        [PreserveSig]
        HRESULT CreatePort([MarshalAs(UnmanagedType.LPStruct)] Guid rclsidPort, ref _DMUS_PORTPARAMS8 pPortParams, out LPDIRECTMUSICPORT ppPort, LPUNKNOWN pUnkOuter);
        
        [PreserveSig]
        HRESULT EnumMasterClock(uint dwIndex, ref _DMUS_CLOCKINFO8 lpClockInfo);
        
        [PreserveSig]
        HRESULT GetMasterClock([MarshalAs(UnmanagedType.LPStruct)] Guid pguidClock, out IReferenceClock ppReferenceClock);
        
        [PreserveSig]
        HRESULT SetMasterClock([MarshalAs(UnmanagedType.LPStruct)] Guid rguidClock);
        
        [PreserveSig]
        HRESULT Activate(bool fEnable);
        
        [PreserveSig]
        HRESULT GetDefaultPort([MarshalAs(UnmanagedType.LPStruct)] Guid pguidPort);
        
        [PreserveSig]
        HRESULT SetDirectSound(LPDIRECTSOUND pDirectSound, IntPtr hWnd);
    }
}
