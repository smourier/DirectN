// generated from <Windows SDK Path>\shared\d3d9types.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_CONFIGUREPROTECTION
    {
        public _D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT Parameters;
        public _D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS Protections;
    }
}
