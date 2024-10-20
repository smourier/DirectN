// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Structure for supplying defines to Dxc APIs.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DxcDefine
    {
        /// <summary>
        /// The define name.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        /// <summary>
        /// Optional value for the define.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Value;
    }
}
