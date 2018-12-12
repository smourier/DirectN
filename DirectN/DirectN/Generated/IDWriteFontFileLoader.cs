// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(671,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("727cad4e-d6af-4c9e-8a08-d695b11caa49"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFileLoader
    {
        [PreserveSig]
        HRESULT CreateStreamFromKey(/* _In_reads_bytes_(fontFileReferenceKeySize) */ IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, /* _COM_Outptr_ */ out IDWriteFontFileStream fontFileStream);
    }
}
