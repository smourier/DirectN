// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(3221,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("24cd47f7-81d8-4785-adb2-af697a963cd2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFBufferListNotify
    {
        [PreserveSig]
        void OnAddSourceBuffer();
        
        [PreserveSig]
        void OnRemoveSourceBuffer();
    }
}
