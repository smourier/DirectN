// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9f8496be-5b9a-41b9-a9e8-f21cd80596c2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMVideoForceKeyFrame
    {
        [PreserveSig]
        HRESULT SetKeyFrame();
    }
}
