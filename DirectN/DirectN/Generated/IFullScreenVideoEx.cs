// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\amvideo.h(172,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFullScreenVideoEx : IFullScreenVideo
    {
        // IFullScreenVideo
        [PreserveSig]
        new HRESULT CountModes(/* THIS_ _Out_ */ out long pModes);
        
        [PreserveSig]
        new HRESULT GetModeInfo(int Mode, /* _Out_ */ out long pWidth, /* _Out_ */ out long pHeight, /* _Out_ */ out long pDepth);
        
        [PreserveSig]
        new HRESULT GetCurrentMode(/* THIS_ _Out_ */ out long pMode);
        
        [PreserveSig]
        new HRESULT IsModeAvailable(int Mode);
        
        [PreserveSig]
        new HRESULT IsModeEnabled(int Mode);
        
        [PreserveSig]
        new HRESULT SetEnabled(int Mode, int bEnabled);
        
        [PreserveSig]
        new HRESULT GetClipFactor(/* THIS_ _Out_ */ out long pClipFactor);
        
        [PreserveSig]
        new HRESULT SetClipFactor(int ClipFactor);
        
        [PreserveSig]
        new HRESULT SetMessageDrain(IntPtr hwnd);
        
        [PreserveSig]
        new HRESULT GetMessageDrain(/* THIS_ _Out_ */ out IntPtr hwnd);
        
        [PreserveSig]
        new HRESULT SetMonitor(int Monitor);
        
        [PreserveSig]
        new HRESULT GetMonitor(/* THIS_ _Out_ */ out long Monitor);
        
        [PreserveSig]
        new HRESULT HideOnDeactivate(int Hide);
        
        [PreserveSig]
        new HRESULT IsHideOnDeactivate();
        
        [PreserveSig]
        new HRESULT SetCaption(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.BStr)] string strCaption);
        
        [PreserveSig]
        new HRESULT GetCaption(/* THIS_ _Outptr_ */ out IntPtr pstrCaption);
        
        [PreserveSig]
        new HRESULT SetDefault();
        
        // IFullScreenVideoEx
        [PreserveSig]
        HRESULT SetAcceleratorTable(IntPtr hwnd, IntPtr hAccel);
        
        [PreserveSig]
        HRESULT GetAcceleratorTable(/* THIS_ _Out_ */ out IntPtr phwnd, IntPtr phAccel);
        
        [PreserveSig]
        HRESULT KeepPixelAspectRatio(int KeepAspect);
        
        [PreserveSig]
        HRESULT IsKeepPixelAspectRatio(/* THIS_ _Out_ */ out long pKeepAspect);
    }
}
