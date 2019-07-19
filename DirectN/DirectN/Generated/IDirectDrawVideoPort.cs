// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dvp.h(148,1)
using System;
using System.Runtime.InteropServices;
using LPDDVIDEOPORTBANDWIDTH = DirectN._DDVIDEOPORTBANDWIDTH;
using LPDDVIDEOPORTINFO = DirectN._DDVIDEOPORTINFO;

namespace DirectN
{
    [Guid("b36d93e0-2b43-11cf-a2de-00aa00b93356"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawVideoPort
    {
        [PreserveSig]
        HRESULT Flip(int LPDIRECTDRAWSURFACE, uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetBandwidthInfo(int LPDDPIXELFORMAT, uint unnamed__1, uint unnamed__2, uint unnamed__3, ref LPDDVIDEOPORTBANDWIDTH unnamed__4);
        
        [PreserveSig]
        HRESULT GetColorControls(int unnamed__0);
        
        [PreserveSig]
        HRESULT GetInputFormats(ref uint lpNumFormats, /* _Out_writes_to_opt_(*lpNumFormats, *lpNumFormats) */ int LPDDPIXELFORMAT, uint unnamed__2);
        
        [PreserveSig]
        HRESULT GetOutputFormats(int LPDDPIXELFORMAT, ref uint lpNumFormats, int unnamed__2, uint unnamed__3);
        
        [PreserveSig]
        HRESULT GetFieldPolarity(ref bool unnamed__0);
        
        [PreserveSig]
        HRESULT GetVideoLine(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetVideoSignalStatus(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT SetColorControls(int unnamed__0);
        
        [PreserveSig]
        HRESULT SetTargetSurface(int LPDIRECTDRAWSURFACE, uint unnamed__1);
        
        [PreserveSig]
        HRESULT StartVideo(ref LPDDVIDEOPORTINFO unnamed__0);
        
        [PreserveSig]
        HRESULT StopVideo();
        
        [PreserveSig]
        HRESULT UpdateVideo(ref LPDDVIDEOPORTINFO unnamed__0);
        
        [PreserveSig]
        HRESULT WaitForSync(uint unnamed__0, uint unnamed__1, uint unnamed__2);
    }
}
