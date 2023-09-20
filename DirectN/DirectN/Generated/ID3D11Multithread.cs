// generated from <Windows SDK Path>\um\d3d11_4.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9b7e4e00-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Multithread
    {
        [PreserveSig]
        void Enter();
        
        [PreserveSig]
        void Leave();
        
        [PreserveSig]
        bool SetMultithreadProtected(/* [annotation] _In_ */ bool bMTProtect);
        
        [PreserveSig]
        bool GetMultithreadProtected();
    }
}
