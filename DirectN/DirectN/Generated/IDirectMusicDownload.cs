// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d2ac287b-b39b-11d1-8704-00600893b1bd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusicDownload
    {
        [PreserveSig]
        HRESULT GetBuffer(IntPtr ppvBuffer, ref uint pdwSize);
    }
}
