// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct AUDIORESOURCEMANAGEMENT_RESOURCEGROUP
    {
        public bool ResourceGroupAcquired;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] 
        public string ResourceGroupName;
    }
}
