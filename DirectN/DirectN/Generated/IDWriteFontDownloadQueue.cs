// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(1456,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface that enqueues download requests for remote fonts, characters, glyphs, and font fragments. Provides methods to asynchronously execute a download, cancel pending downloads, and be notified of download completion. Callbacks to listeners will occur on the downloading thread, and objects must be must be able to handle calls on their methods from other threads at any time.
    /// </summary>
    [ComImport, Guid("b71e6052-5aea-4fa3-832e-f60d431f7e91"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontDownloadQueue
    {
        [PreserveSig]
        HRESULT AddListener(IDWriteFontDownloadListener listener, /* _Out_ */ out uint token);
        
        [PreserveSig]
        HRESULT RemoveListener(uint token);
        
        [PreserveSig]
        bool IsEmpty();
        
        [PreserveSig]
        HRESULT BeginDownload(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object context);
        
        [PreserveSig]
        HRESULT CancelDownload();
        
        [PreserveSig]
        ulong GetGenerationCount();
    }
}
