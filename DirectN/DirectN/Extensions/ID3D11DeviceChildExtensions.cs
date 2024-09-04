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

        public static IComObject<ID3D11Device> GetDevice(this IComObject<ID3D11DeviceChild> child) => GetDevice<ID3D11Device>(child?.Object);
        public static IComObject<T> GetDevice<T>(this IComObject<ID3D11DeviceChild> child) where T : ID3D11Device => GetDevice<T>(child?.Object);
        public static IComObject<T> GetDevice<T>(this ID3D11DeviceChild child) where T : ID3D11Device
        {
            if (child == null)
                throw new ArgumentNullException(nameof(child));

            child.GetDevice(out var device);
            return new ComObject<T>((T)device);
        }
    }
}
