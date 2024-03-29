﻿// generated from <Windows SDK Path>\um\dxgidebug.h
using System;
using System.Runtime.InteropServices;
using DXGI_DEBUG_ID = System.Guid;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_INFO_QUEUE_MESSAGE
    {
        public DXGI_DEBUG_ID Producer;
        public DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category;
        public DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity;
        public int ID;
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte pDescription;
        public IntPtr DescriptionByteLength;
    }
}
