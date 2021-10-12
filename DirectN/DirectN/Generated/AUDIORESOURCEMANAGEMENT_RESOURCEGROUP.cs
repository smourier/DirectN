// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(8182,9)
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
