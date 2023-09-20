// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("24cd47f7-81d8-4785-adb2-af697a963cd2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFBufferListNotify
    {
        [PreserveSig]
        void OnAddSourceBuffer();
        
        [PreserveSig]
        void OnRemoveSourceBuffer();
    }
}
