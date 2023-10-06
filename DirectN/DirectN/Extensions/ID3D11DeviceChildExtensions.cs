using System;

namespace DirectN
{
    public static class ID3D11DeviceChildExtensions
    {
        public static void SetDebugObjectName(this IComObject<ID3D11DeviceChild> child, string name) => SetDebugObjectName(child?.Object, name);
        public static void SetDebugObjectName(this ID3D11DeviceChild child, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(null, nameof(name));

            using (var mem = new ComMemory(name))
            {
                _ = child.SetPrivateData(Constants.WKPDID_D3DDebugObjectNameW, (uint)(name.Length * 2), mem.Pointer).ThrowOnError();
            }
        }
    }
}
