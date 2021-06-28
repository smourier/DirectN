// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_3.h(1430,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Application-defined callback interface that receives notifications from the font download queue (IDWriteFontDownloadQueue interface). Callbacks will occur on the downloading thread, and objects must be prepared to handle calls on their methods from other threads at any time.
    /// </summary>
    [ComImport, Guid("b06fe5b9-43ec-4393-881b-dbe4dc72fda7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontDownloadListener
    {
        [PreserveSig]
        void DownloadCompleted(/* _In_ */ IDWriteFontDownloadQueue downloadQueue, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object context, HRESULT downloadResult);
    }
}
