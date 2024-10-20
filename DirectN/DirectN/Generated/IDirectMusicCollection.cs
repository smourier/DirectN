// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d2ac287c-b39b-11d1-8704-00600893b1bd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusicCollection
    {
        [PreserveSig]
        HRESULT GetInstrument(uint dwPatch, out IDirectMusicInstrument ppInstrument);
        
        [PreserveSig]
        HRESULT EnumInstrument(uint dwIndex, ref uint pdwPatch, [MarshalAs(UnmanagedType.LPWStr)] string pwszName, uint dwNameLen);
    }
}
