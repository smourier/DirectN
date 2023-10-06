// generated from <Windows SDK Path>\um\d2d1_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("31e6e7bc-e0ff-4d46-8c64-a0a8c41c15d3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Multithread
    {
        [PreserveSig]
        bool GetMultithreadProtected();
        
        [PreserveSig]
        void Enter();
        
        [PreserveSig]
        void Leave();
    }
}
