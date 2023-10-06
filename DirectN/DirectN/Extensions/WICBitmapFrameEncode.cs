using System;

namespace DirectN
{
    public sealed class WICBitmapFrameEncode : IDisposable
    {
        public WICBitmapFrameEncode(IComObject<IWICBitmapFrameEncode> encode, IComObject<IPropertyBag2> bag)
        {
            if (encode == null)
                throw new ArgumentNullException(nameof(encode));

            if (bag == null)
                throw new ArgumentNullException(nameof(bag));

            Encode = encode;
            Bag = bag;
        }

        public WICBitmapFrameEncode(IWICBitmapFrameEncode encode, IPropertyBag2 bag)
        {
            if (encode == null)
                throw new ArgumentNullException(nameof(encode));

            if (bag == null)
                throw new ArgumentNullException(nameof(bag));

            Encode = new ComObject<IWICBitmapFrameEncode>(encode);
            Bag = new ComObject<IPropertyBag2>(bag);
        }

        public IComObject<IWICBitmapFrameEncode> Encode { get; }
        public IComObject<IPropertyBag2> Bag { get; }

        public void Dispose()
        {
            Encode.SafeDispose();
            Bag.SafeDispose();
        }
    }
}
