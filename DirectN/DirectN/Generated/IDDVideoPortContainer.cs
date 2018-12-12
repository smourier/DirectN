// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dvp.h(108,1)
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
        HRESULT CreateVideoPort(uint __unnamed_0, ref LPDDVIDEOPORTDESC __unnamed_1, out LPDIRECTDRAWVIDEOPORT __unnamed_2, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_3);
        
        [PreserveSig]
        HRESULT EnumVideoPorts(uint __unnamed_0, ref LPDDVIDEOPORTCAPS __unnamed_1, IntPtr __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT GetVideoPortConnectInfo(uint __unnamed_0, /* _Inout_ */ ref uint pcInfo, /* _Out_writes_to_opt_(*pcInfo, *pcInfo) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] LPDDVIDEOPORTCONNECT[] __unnamed_2);
        
        [PreserveSig]
        HRESULT QueryVideoPortStatus(uint __unnamed_0, ref LPDDVIDEOPORTSTATUS __unnamed_1);
    }
}
