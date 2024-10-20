// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTMUSICPORT = DirectN.IDirectMusicPort;

namespace DirectN
{
    [ComImport, Guid("ced153e7-3606-11d2-b9f9-0000f875ac12"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusicThru
    {
        [PreserveSig]
        HRESULT ThruChannel(uint dwSourceChannelGroup, uint dwSourceChannel, uint dwDestinationChannelGroup, uint dwDestinationChannel, LPDIRECTMUSICPORT pDestinationPort);
    }
}
