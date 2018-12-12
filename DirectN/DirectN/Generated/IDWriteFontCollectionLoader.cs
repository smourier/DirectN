// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(1311,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("cca920e4-52f0-492b-bfa8-29c72ee0a468"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontCollectionLoader
    {
        [PreserveSig]
        HRESULT CreateEnumeratorFromKey(/* _In_ */ IDWriteFactory factory, /* _In_reads_bytes_(collectionKeySize) */ IntPtr collectionKey, uint collectionKeySize, /* _COM_Outptr_ */ out IDWriteFontFileEnumerator fontFileEnumerator);
    }
}
