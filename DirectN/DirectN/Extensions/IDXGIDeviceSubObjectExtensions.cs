using System;

namespace DirectN
{
    public static class IDXGIDeviceSubObjectExtensions
    {
        public static IComObject<IDXGIDevice> GetDevice(this IDXGIDeviceSubObject subObject)
        {
            if (subObject == null)
                throw new ArgumentNullException(nameof(subObject));

            subObject.GetDevice(typeof(IDXGIDevice).GUID, out var device).ThrowOnError();
            return new ComObject<IDXGIDevice>((IDXGIDevice)device);
        }

        public static IComObject<IDXGIDevice1> GetDevice1(this IDXGIDeviceSubObject subObject)
        {
            if (subObject == null)
                throw new ArgumentNullException(nameof(subObject));

            subObject.GetDevice(typeof(IDXGIDevice1).GUID, out var device).ThrowOnError();
            return new ComObject<IDXGIDevice1>((IDXGIDevice1)device);
        }
    }
}
