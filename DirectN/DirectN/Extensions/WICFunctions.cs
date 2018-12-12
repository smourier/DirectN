namespace DirectN
{
    public static class WICFunctions
    {
        public static ComObject<IWICImagingFactory> CreateFactory() => CreateFactory<IWICImagingFactory>();
        public static ComObject<IWICImagingFactory2> CreateFactory2() => CreateFactory<IWICImagingFactory2>();
        public static ComObject<T> CreateFactory<T>() where T : IWICImagingFactory
        {
            var factory = new WicImagingFactory();
            return new ComObject<T>((T)(object)factory);
        }
    }
}
