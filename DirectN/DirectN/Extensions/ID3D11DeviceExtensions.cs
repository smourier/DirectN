using System;

namespace DirectN
{
    public static class ID3D11DeviceExtensions
    {
        public static ComObject<T> CreateTexture2D<T>(this ComObject<ID3D11Device> device, D3D11_TEXTURE2D_DESC desc) where T : ID3D11Texture2D => CreateTexture2D<T>(device?.Object, desc);
        public static ComObject<T> CreateTexture2D<T>(this ID3D11Device device, D3D11_TEXTURE2D_DESC desc) where T : ID3D11Texture2D
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateTexture2D(ref desc, null, out var texture).ThrowOnError();
            return new ComObject<T>((T)texture);
        }

        public static ComObject<ID3D11DeviceContext> GetImmediateContext(this ComObject<ID3D11Device> obj) => GetImmediateContext(obj?.Object);
        public static ComObject<ID3D11DeviceContext> GetImmediateContext(this ID3D11Device obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

#pragma warning disable CA2010 // Always consume the value returned by methods marked with PreserveSigAttribute
            obj.GetImmediateContext(out var value);
#pragma warning restore CA2010 // Always consume the value returned by methods marked with PreserveSigAttribute
            return value != null ? new ComObject<ID3D11DeviceContext>(value) : null;
        }
    }
}
