﻿// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("249981f8-8325-41f3-b80c-3b9e3aad0cbe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceBufferList
    {
        [PreserveSig]
        uint GetLength();
        
        [PreserveSig]
        IMFSourceBuffer GetSourceBuffer(/* [annotation][in] _In_ */ uint index);
    }
}
