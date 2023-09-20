// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("87e47623-2ceb-45d6-9b88-d8520c4dcbbc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceBufferNotify
    {
        [PreserveSig]
        void OnUpdateStart();
        
        [PreserveSig]
        void OnAbort();
        
        [PreserveSig]
        void OnError(/* [annotation][in] _In_ */ HRESULT hr);
        
        [PreserveSig]
        void OnUpdate();
        
        [PreserveSig]
        void OnUpdateEnd();
    }
}
