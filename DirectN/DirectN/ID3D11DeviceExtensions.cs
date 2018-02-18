using System;

namespace DirectN
{
    public static class ID3D11DeviceExtensions
    {
        public static ComObject<T> ToDevice<T>(this ComObject<ID3D11Device> device) where T : IDXGIDevice => ToDevice<T>(device?.Object);
        public static ComObject<T> ToDevice<T>(this ID3D11Device device) where T : IDXGIDevice
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            return new ComObject<T>((T)device);
        }
    }
}
