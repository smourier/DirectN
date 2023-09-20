// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("76c6a6f5-4955-4de5-b27b-14b734cc14b4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextRuby
    {
        [PreserveSig]
        HRESULT GetRubyText(/* [annotation][out] _Outptr_ */ out IntPtr rubyText);
        
        [PreserveSig]
        HRESULT GetRubyPosition(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_RUBY_POSITION value);
        
        [PreserveSig]
        HRESULT GetRubyAlign(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_RUBY_ALIGN value);
        
        [PreserveSig]
        HRESULT GetRubyReserve(/* [annotation][out] _Out_ */ out MF_TIMED_TEXT_RUBY_RESERVE value);
    }
}
