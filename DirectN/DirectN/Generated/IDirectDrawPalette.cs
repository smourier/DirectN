// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(1362,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6c14db84-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawPalette
    {
        [PreserveSig]
        HRESULT GetCaps(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetEntries(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT Initialize(IntPtr __unnamed_0, uint __unnamed_1, IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT SetEntries(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2, IntPtr __unnamed_3);
    }
}
