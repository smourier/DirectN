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
        HRESULT Flip(int LPDIRECTDRAWSURFACE, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetBandwidthInfo(int LPDDPIXELFORMAT, uint __unnamed_1, uint __unnamed_2, uint __unnamed_3, ref LPDDVIDEOPORTBANDWIDTH __unnamed_4);
        
        [PreserveSig]
        HRESULT GetColorControls(int __unnamed_0);
        
        [PreserveSig]
        HRESULT GetInputFormats(ref uint lpNumFormats, /* _Out_writes_to_opt_(*lpNumFormats, *lpNumFormats) */ int LPDDPIXELFORMAT, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT GetOutputFormats(int LPDDPIXELFORMAT, ref uint lpNumFormats, int __unnamed_2, uint __unnamed_3);
        
        [PreserveSig]
        HRESULT GetFieldPolarity(ref bool __unnamed_0);
        
        [PreserveSig]
        HRESULT GetVideoLine(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetVideoSignalStatus(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT SetColorControls(int __unnamed_0);
        
        [PreserveSig]
        HRESULT SetTargetSurface(int LPDIRECTDRAWSURFACE, uint __unnamed_1);
        
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
