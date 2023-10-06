using System;

namespace DirectN
{
    public static class ID2D1EffectExtensions
    {
        public static void SetInput(this IComObject<ID2D1Effect> effect, IComObject<ID2D1Image> image, int index = 0, bool invalidate = false) => SetInput(effect?.Object, image?.Object, index, invalidate);
        public static void SetInput(this ID2D1Effect effect, ID2D1Image image, int index = 0, bool invalidate = false)
        {
            if (effect == null)
                throw new ArgumentNullException(nameof(effect));

            if (image == null)
                throw new ArgumentNullException(nameof(image));

            effect.SetInput((uint)index, image, invalidate);
        }

        public static void SetInput(this IComObject<ID2D1Effect> effect, IComObject<ID2D1Effect> input = null, int index = 0, bool invalidate = false) => SetInput(effect?.Object, input?.Object, index, invalidate);
        public static void SetInput(this ID2D1Effect effect, ID2D1Effect input = null, int index = 0, bool invalidate = false)
        {
            if (effect == null)
                throw new ArgumentNullException(nameof(effect));

            if (input == null)
                throw new ArgumentNullException(nameof(input));

            using (var output = input.GetOutput())
            {
                effect.SetInput((uint)index, output.Object, invalidate);
            }
        }

        public static IComObject<ID2D1Image> GetInput(this IComObject<ID2D1Effect> effect, uint index) => GetInput(effect?.Object, index);
        public static IComObject<ID2D1Image> GetInput(this ID2D1Effect effect, uint index)
        {
            if (effect == null)
                throw new ArgumentNullException(nameof(effect));

            effect.GetInput(index, out var image);
            return new ComObject<ID2D1Image>(image);
        }

        public static uint GetInputCount(this IComObject<ID2D1Effect> effect) => GetInputCount(effect?.Object);
        public static uint GetInputCount(this ID2D1Effect effect)
        {
            if (effect == null)
                throw new ArgumentNullException(nameof(effect));

            return effect.GetInputCount();
        }

        public static void SetInputCount(this IComObject<ID2D1Effect> effect, uint count) => SetInputCount(effect?.Object, count);
        public static void SetInputCount(this ID2D1Effect effect, uint count)
        {
            if (effect == null)
                throw new ArgumentNullException(nameof(effect));

            effect.SetInputCount(count).ThrowOnError();
        }

        public static IComObject<ID2D1Image> GetOutput(this IComObject<ID2D1Effect> effect) => GetOutput(effect?.Object);
        public static IComObject<ID2D1Image> GetOutput(this ID2D1Effect effect)
        {
            if (effect == null)
                throw new ArgumentNullException(nameof(effect));

            effect.GetOutput(out var image);
            return new ComObject<ID2D1Image>(image);
        }
    }
}
