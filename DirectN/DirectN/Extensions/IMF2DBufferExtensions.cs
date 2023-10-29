using System;

namespace DirectN
{
    public static class IMF2DBufferExtensions
    {
        public static uint GetContiguousLength(this IComObject<IMF2DBuffer> obj) => GetContiguousLength(obj?.Object);
        public static uint GetContiguousLength(this IMF2DBuffer obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetContiguousLength(out var length).ThrowOnError();
            return length;
        }
    }
}
