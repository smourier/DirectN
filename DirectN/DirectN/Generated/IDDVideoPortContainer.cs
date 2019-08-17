// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dvp.h(108,1)
using System;
using System.Runtime.InteropServices;
using LPDDVIDEOPORTCAPS = DirectN._DDVIDEOPORTCAPS;
using LPDDVIDEOPORTCONNECT = DirectN._DDVIDEOPORTCONNECT;
using LPDDVIDEOPORTDESC = DirectN._DDVIDEOPORTDESC;
using LPDDVIDEOPORTSTATUS = DirectN._DDVIDEOPORTSTATUS;
using LPDIRECTDRAWVIDEOPORT = DirectN.IDirectDrawVideoPort;

namespace DirectN
{
    [Guid("6c142760-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDDVideoPortContainer
    {
        [PreserveSig]
        HRESULT CreateVideoPort(uint unnamed__0, ref LPDDVIDEOPORTDESC unnamed__1, out LPDIRECTDRAWVIDEOPORT unnamed__2, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__3);
        
        [PreserveSig]
        HRESULT EnumVideoPorts(uint unnamed__0, ref LPDDVIDEOPORTCAPS unnamed__1, IntPtr unnamed__2, IntPtr unnamed__3);
        
        [PreserveSig]
        HRESULT GetVideoPortConnectInfo(uint unnamed__0, /* _Inout_ */ ref int pcInfo, /* _Out_writes_to_opt_(*pcInfo, *pcInfo) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] LPDDVIDEOPORTCONNECT[] unnamed__2);
        
        [PreserveSig]
        HRESULT QueryVideoPortStatus(uint unnamed__0, ref LPDDVIDEOPORTSTATUS unnamed__1);
    }
}
