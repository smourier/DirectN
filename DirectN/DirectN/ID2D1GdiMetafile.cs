using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("82237326-8111-4f7c-bcf4-b5c1175564fe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1GdiMetafile
    {
        [PreserveSig]
        HRESULT ProcessRecord(int recordType, IntPtr recordData, int recordDataSize);
    }
}
