// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudiometadata.h(475,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b78e86a2-31d9-4c32-94d2-7df40fc7ebec"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioMetadataReader
    {
        [PreserveSig]
        HRESULT Open(/* [annotation][in] _In_ */ ISpatialAudioMetadataItems metadataItems);
        
        [PreserveSig]
        HRESULT ReadNextItem(/* [annotation][out] _Out_ */ out byte commandCount, /* [annotation][out] _Out_ */ out ushort frameOffset);
        
        [PreserveSig]
        HRESULT ReadNextItemCommand(/* [annotation][out] _Out_ */ out byte commandID, /* [annotation][size_is][in] _Out_writes_bytes_(maxValueBufferLength) */ IntPtr valueBuffer, /* [annotation][in] _In_ */ uint maxValueBufferLength, /* [annotation][out] _Out_ */ out uint valueBufferLength);
        
        [PreserveSig]
        HRESULT Close();
    }
}
