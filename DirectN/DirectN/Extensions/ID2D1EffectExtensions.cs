using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ID2D1EffectExtensions
    {
        //public static void SetInput(this IComObject<ID2D1Effect> effect, IComObject<ID2D1Bitmap1> bitmap, int index = 0, bool invalidate = false) => SetInput(effect?.Object, bitmap?.Object, index, invalidate);
        public static void SetInput(this IComObject<ID2D1Effect> effect, IComObject<ID2D1Bitmap> bitmap, int index = 0, bool invalidate = false) => SetInput(effect?.Object, bitmap?.Object, index, invalidate);
        public static void SetInput(this IComObject<ID2D1Effect> effect, IComObject<ID2D1Image> image, int index = 0, bool invalidate = false) => SetInput(effect?.Object, image?.Object, index, invalidate);
        public static void SetInput(this ID2D1Effect effect, ID2D1Image image, int index = 0, bool invalidate = false)
        {
            if (effect == null)
                throw new ArgumentNullException(nameof(effect));

            if (image == null)
                throw new ArgumentNullException(nameof(image));

            effect.SetInput((uint)index, image, invalidate);
        }

        public static void SetInputEffect(this IComObject<ID2D1Effect> effect, IComObject<ID2D1Effect> inputEffect, int index = 0, bool invalidate = false) => SetInputEffect(effect?.Object, inputEffect?.Object, index, invalidate);
        public static void SetInputEffect(this ID2D1Effect effect, ID2D1Effect inputEffect, int index = 0, bool invalidate = false)
        {
            if (effect == null)
                throw new ArgumentNullException(nameof(effect));

            if (inputEffect == null)
                throw new ArgumentNullException(nameof(inputEffect));

            inputEffect.GetOutput(out var output);
            effect.SetInput((uint)index, output, invalidate);
            Marshal.ReleaseComObject(output);
        }
    }
}
