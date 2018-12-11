// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dvp.h(148,1)
using System;
using System.Runtime.InteropServices;
using LPDDCOLORCONTROL = DirectN._DDCOLORCONTROL;
using LPDDVIDEOPORTBANDWIDTH = DirectN._DDVIDEOPORTBANDWIDTH;
using LPDDVIDEOPORTINFO = DirectN._DDVIDEOPORTINFO;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [Guid("b36d93e0-2b43-11cf-a2de-00aa00b93356"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawVideoPort
    {
        [PreserveSig]
        HRESULT Flip(ref LPDIRECTDRAWSURFACE __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetBandwidthInfo(ref _DDPIXELFORMAT __unnamed_0, uint __unnamed_1, uint __unnamed_2, uint __unnamed_3, ref LPDDVIDEOPORTBANDWIDTH __unnamed_4);
        
        [PreserveSig]
        HRESULT GetColorControls(ref LPDDCOLORCONTROL __unnamed_0);
        
        [PreserveSig]
        HRESULT GetInputFormats(ref uint lpNumFormats, /* _Out_writes_to_opt_(*lpNumFormats, *lpNumFormats) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _DDPIXELFORMAT[] __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT GetOutputFormats(ref _DDPIXELFORMAT __unnamed_0, ref uint lpNumFormats, /* _Out_writes_to_opt_(*lpNumFormats, *lpNumFormats) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _DDPIXELFORMAT[] __unnamed_2, uint __unnamed_3);
        
        [PreserveSig]
        HRESULT GetFieldPolarity(ref bool __unnamed_0);
        
        [PreserveSig]
        HRESULT GetVideoLine(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetVideoSignalStatus(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT SetColorControls(ref LPDDCOLORCONTROL __unnamed_0);
        
        [PreserveSig]
        HRESULT SetTargetSurface(ref LPDIRECTDRAWSURFACE __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT StartVideo(ref LPDDVIDEOPORTINFO __unnamed_0);
        
        [PreserveSig]
        HRESULT StopVideo();
        
        [PreserveSig]
        HRESULT UpdateVideo(ref LPDDVIDEOPORTINFO __unnamed_0);
        
        [PreserveSig]
        HRESULT WaitForSync(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2);
    }
}
