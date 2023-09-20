// generated from <Windows SDK Path>\shared\d3d9types.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERYEVICTIONENCRYPTIONGUID_INPUT_32
    {
        public _D3DAUTHENTICATEDCHANNEL_QUERY_INPUT_32 Input;
        public uint EncryptionGuidIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERYEVICTIONENCRYPTIONGUID_INPUT_64
    {
        public _D3DAUTHENTICATEDCHANNEL_QUERY_INPUT_64 Input;
        public uint EncryptionGuidIndex;
    }
}
