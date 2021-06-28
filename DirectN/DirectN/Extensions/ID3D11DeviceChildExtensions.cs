using System;

namespace DirectN
{
    public static class ID3D11DeviceChildExtensions
    {
#pragma warning disable IDE1006 // Naming Styles
        private static readonly Guid WKPDID_D3DDebugObjectNameW = new Guid("4cca5fd8-921f-42c8-8566-70caf2a9b741");
#pragma warning restore IDE1006 // Naming Styles

        public static void SetDebugObjectName(this IComObject<ID3D11DeviceChild> child, string name) => SetDebugObjectName(child?.Object, name);
        public static void SetDebugObjectName(this ID3D11DeviceChild child, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(null, nameof(name));

            using (var mem = new ComMemory(name))
            {
#pragma warning disable CA1062 // Validate arguments of public methods
                _ = child.SetPrivateData(WKPDID_D3DDebugObjectNameW, (uint)(name.Length * 2), mem.Pointer).ThrowOnError();
#pragma warning restore CA1062 // Validate arguments of public methods
            }
        }
    }
}
