using System;

namespace DirectN
{
    public static class ID2D1FactoryExtensions
    {
        public static ComObject<ID2D1Device> CreateDevice(this ComObject<ID2D1Factory1> factory, ComObject<IDXGIDevice> device) => CreateDevice<ID2D1Device>(factory?.Object, device?.Object);
        public static ComObject<T> CreateDevice<T>(this ComObject<ID2D1Factory1> factory, ComObject<IDXGIDevice> device) where T : ID2D1Device => CreateDevice<T>(factory?.Object, device?.Object);
        public static ComObject<T> CreateDevice<T>(this ID2D1Factory1 factory, IDXGIDevice device) where T : ID2D1Device
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (device == null)
                throw new ArgumentNullException(nameof(device));

            factory.CreateDevice(device, out var dev).ThrowOnError();
            return new ComObject<T>((T)dev);
        }

        public static ComObject<ID2D1DCRenderTarget> CreateDCRenderTarget(this ComObject<ID2D1Factory1> factory, D2D1_RENDER_TARGET_PROPERTIES properties) => CreateDCRenderTarget<ID2D1DCRenderTarget>(factory?.Object, properties);
        public static ComObject<T> CreateDCRenderTarget<T>(this ComObject<ID2D1Factory1> factory, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1DCRenderTarget => CreateDCRenderTarget<T>(factory?.Object, properties);
        public static ComObject<T> CreateDCRenderTarget<T>(this ID2D1Factory1 factory, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1DCRenderTarget
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateDCRenderTarget(ref properties, out var target).ThrowOnError();
            return new ComObject<T>((T)target);
        }
    }
}
