// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(1362,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAW = DirectN.IDirectDraw;

namespace DirectN
{
    [Guid("6c14db84-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawPalette
    {
        [PreserveSig]
        HRESULT GetCaps(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetEntries(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2, ref tagPALETTEENTRY __unnamed_3);
        
        [PreserveSig]
        HRESULT Initialize(ref LPDIRECTDRAW __unnamed_0, uint __unnamed_1, ref tagPALETTEENTRY __unnamed_2);
        
        [PreserveSig]
        HRESULT SetEntries(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2, ref tagPALETTEENTRY __unnamed_3);
    }
}
