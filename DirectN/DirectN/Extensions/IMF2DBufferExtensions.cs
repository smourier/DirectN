using System;

namespace DirectN
{
    public static class IMF2DBufferExtensions
    {
        public static uint GetContiguousLength(this ComObject<IMF2DBuffer> input) => GetContiguousLength(input?.Object);
        public static uint GetContiguousLength(this IMF2DBuffer input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.GetContiguousLength(out var length).ThrowOnError();
            return length;
        }
    }
}
