// generated from <Windows SDK Path>\um\spatialaudiometadata.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioObjectRenderStreamForMetadataActivationParams
    {
        public IntPtr ObjectFormat;
        public AudioObjectType StaticObjectTypeMask;
        public uint MinDynamicObjectCount;
        public uint MaxDynamicObjectCount;
        public _AUDIO_STREAM_CATEGORY Category;
        public IntPtr EventHandle;
        public Guid MetadataFormatId;
        public ushort MaxMetadataItemCount;
        public IntPtr MetadataActivationParams;
        public IntPtr NotifyObject;
    }
}
