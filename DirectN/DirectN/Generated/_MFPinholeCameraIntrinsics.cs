// generated from <Windows SDK Path>\um\mfapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFPinholeCameraIntrinsics
    {
        public uint IntrinsicModelCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _MFPinholeCameraIntrinsic_IntrinsicModel[] IntrinsicModels;
    }
}
