// generated from <Windows SDK Path>\um\spatialaudiometadata.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1b17ca01-2955-444d-a430-537dc589a844"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpatialAudioMetadataWriter
    {
        [PreserveSig]
        HRESULT Open(/* [annotation][in] _In_ */ ISpatialAudioMetadataItems metadataItems);
        
        [PreserveSig]
        HRESULT WriteNextItem(/* [annotation][in] _In_ */ ushort frameOffset);
        
        [PreserveSig]
        HRESULT WriteNextItemCommand(/* [annotation][in] _In_ */ byte commandID, /* optional(void) */ IntPtr valueBuffer, /* [annotation][in] _In_ */ uint valueBufferLength);
        
        [PreserveSig]
        HRESULT Close();
    }
}
