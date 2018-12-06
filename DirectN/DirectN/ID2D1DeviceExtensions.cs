using System;

namespace DirectN
{
    public static class ID2D1DeviceExtensions
    {
        public static ComObject<ID2D1DeviceContext> CreateDeviceContext(this ComObject<ID2D1Device> device, D2D1_DEVICE_CONTEXT_OPTIONS options = 0) => CreateDeviceContext<ID2D1DeviceContext>(device?.Object, options);
        public static ComObject<T> CreateDeviceContext<T>(this ComObject<ID2D1Device> device, D2D1_DEVICE_CONTEXT_OPTIONS options = 0) where T : ID2D1DeviceContext => CreateDeviceContext<T>(device?.Object, options);
        public static ComObject<T> CreateDeviceContext<T>(this ID2D1Device device, D2D1_DEVICE_CONTEXT_OPTIONS options = 0) where T : ID2D1DeviceContext
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateDeviceContext(options, out var dc).ThrowOnError();
            return new ComObject<T>((T)dc);
        }
    }
}
