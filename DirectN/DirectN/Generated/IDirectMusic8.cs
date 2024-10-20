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
    [ComImport, Guid("2d3629f7-813d-4939-8508-f05c6b75fd97"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusic8 : IDirectMusic
    {
        // IDirectMusic
        [PreserveSig]
        new HRESULT EnumPort(uint dwIndex, ref _DMUS_PORTCAPS pPortCaps);
        
        [PreserveSig]
        new HRESULT CreateMusicBuffer(ref LPDMUS_BUFFERDESC pBufferDesc, out LPDIRECTMUSICBUFFER ppBuffer, LPUNKNOWN pUnkOuter);
        
        [PreserveSig]
        new HRESULT CreatePort([MarshalAs(UnmanagedType.LPStruct)] Guid rclsidPort, ref _DMUS_PORTPARAMS8 pPortParams, out LPDIRECTMUSICPORT ppPort, LPUNKNOWN pUnkOuter);
        
        [PreserveSig]
        new HRESULT EnumMasterClock(uint dwIndex, ref _DMUS_CLOCKINFO8 lpClockInfo);
        
        [PreserveSig]
        new HRESULT GetMasterClock([MarshalAs(UnmanagedType.LPStruct)] Guid pguidClock, out IReferenceClock ppReferenceClock);
        
        [PreserveSig]
        new HRESULT SetMasterClock([MarshalAs(UnmanagedType.LPStruct)] Guid rguidClock);
        
        [PreserveSig]
        new HRESULT Activate(bool fEnable);
        
        [PreserveSig]
        new HRESULT GetDefaultPort([MarshalAs(UnmanagedType.LPStruct)] Guid pguidPort);
        
        [PreserveSig]
        new HRESULT SetDirectSound(LPDIRECTSOUND pDirectSound, IntPtr hWnd);
        
        // IDirectMusic8
        [PreserveSig]
        HRESULT SetExternalMasterClock(IReferenceClock pClock);
    }
}
