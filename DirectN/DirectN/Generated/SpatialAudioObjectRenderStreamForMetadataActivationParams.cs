// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\spatialaudiometadata.h(153,9)
using System;
using System.Runtime.InteropServices;
using WAVEFORMATEX = DirectN.tWAVEFORMATEX;

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
