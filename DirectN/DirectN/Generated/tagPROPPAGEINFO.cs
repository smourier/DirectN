﻿// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagPROPPAGEINFO
    {
        public uint cb;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszTitle;
        public tagSIZE size;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszDocString;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pszHelpFile;
        public uint dwHelpContext;
    }
}
