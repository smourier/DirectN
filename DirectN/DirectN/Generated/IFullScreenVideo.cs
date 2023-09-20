// generated from <Windows SDK Path>\um\amvideo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dd1d7110-7836-11cf-bf47-00aa0055595a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFullScreenVideo
    {
        [PreserveSig]
        HRESULT CountModes(/* THIS_ _Out_ */ out long pModes);
        
        [PreserveSig]
        HRESULT GetModeInfo(int Mode, /* _Out_ */ out long pWidth, /* _Out_ */ out long pHeight, /* _Out_ */ out long pDepth);
        
        [PreserveSig]
        HRESULT GetCurrentMode(/* THIS_ _Out_ */ out long pMode);
        
        [PreserveSig]
        HRESULT IsModeAvailable(int Mode);
        
        [PreserveSig]
        HRESULT IsModeEnabled(int Mode);
        
        [PreserveSig]
        HRESULT SetEnabled(int Mode, int bEnabled);
        
        [PreserveSig]
        HRESULT GetClipFactor(/* THIS_ _Out_ */ out long pClipFactor);
        
        [PreserveSig]
        HRESULT SetClipFactor(int ClipFactor);
        
        [PreserveSig]
        HRESULT SetMessageDrain(IntPtr hwnd);
        
        [PreserveSig]
        HRESULT GetMessageDrain(/* THIS_ _Out_ */ out IntPtr hwnd);
        
        [PreserveSig]
        HRESULT SetMonitor(int Monitor);
        
        [PreserveSig]
        HRESULT GetMonitor(/* THIS_ _Out_ */ out long Monitor);
        
        [PreserveSig]
        HRESULT HideOnDeactivate(int Hide);
        
        [PreserveSig]
        HRESULT IsHideOnDeactivate();
        
        [PreserveSig]
        HRESULT SetCaption(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.BStr)] string strCaption);
        
        [PreserveSig]
        HRESULT GetCaption(/* THIS_ _Outptr_ */ out IntPtr pstrCaption);
        
        [PreserveSig]
        HRESULT SetDefault();
    }
}
