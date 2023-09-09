using System;

namespace DirectN
{
    public static class ID3D9BitnessExtensions
    {
        public static HRESULT WithLockRect(this IDirect3DSurface9 surface, IntPtr pRect, uint Flags, Action<int, IntPtr> action)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            HRESULT hr;
            if (IntPtr.Size == 8)
            {
                var rc = new _D3DLOCKED_RECT_64();
                hr = surface.LockRect(ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        action(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        surface.UnlockRect();
                    }
                }
            }
            else
            {
                var rc = new _D3DLOCKED_RECT_32();
                hr = surface.LockRect(ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        action(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        surface.UnlockRect();
                    }
                }
            }
            return hr;
        }

        public static T WithLockRect<T>(this IDirect3DSurface9 surface, IntPtr pRect, uint Flags, Func<int, IntPtr, T> func)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            if (func == null)
                throw new ArgumentNullException(nameof(func));

            HRESULT hr;
            if (IntPtr.Size == 8)
            {
                var rc = new _D3DLOCKED_RECT_64();
                hr = surface.LockRect(ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        return func(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        surface.UnlockRect();
                    }
                }
            }
            else
            {
                var rc = new _D3DLOCKED_RECT_32();
                hr = surface.LockRect(ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        return func(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        surface.UnlockRect();
                    }
                }
            }
            return default;
        }

        public static HRESULT LockRect(this IDirect3DSurface9 surface, ref _D3DLOCKED_RECT_64 pLockedRect, IntPtr pRect, uint Flags)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            using (var mem = new ComMemory(pLockedRect))
            {
                var hr = surface.LockRect(mem.Pointer, pRect, Flags);
                if (hr.IsSuccess)
                {
                    pLockedRect = mem.ToStructure<_D3DLOCKED_RECT_64>();
                }
                return hr;
            }
        }

        public static HRESULT LockRect(this IDirect3DSurface9 surface, ref _D3DLOCKED_RECT_32 pLockedRect, IntPtr pRect, uint Flags)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            using (var mem = new ComMemory(pLockedRect))
            {
                var hr = surface.LockRect(mem.Pointer, pRect, Flags);
                if (hr.IsSuccess)
                {
                    pLockedRect = mem.ToStructure<_D3DLOCKED_RECT_32>();
                }
                return hr;
            }
        }

        public static HRESULT WithLockRect(this IDirect3DTexture9 texture, uint level, IntPtr pRect, uint Flags, Action<int, IntPtr> action)
        {
            if (texture == null)
                throw new ArgumentNullException(nameof(texture));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            HRESULT hr;
            if (IntPtr.Size == 8)
            {
                var rc = new _D3DLOCKED_RECT_64();
                hr = texture.LockRect(level, ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        action(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        texture.UnlockRect(level);
                    }
                }
            }
            else
            {
                var rc = new _D3DLOCKED_RECT_32();
                hr = texture.LockRect(level, ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        action(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        texture.UnlockRect(level);
                    }
                }
            }
            return hr;
        }

        public static T WithLockRect<T>(this IDirect3DTexture9 texture, uint level, IntPtr pRect, uint Flags, Func<int, IntPtr, T> func)
        {
            if (texture == null)
                throw new ArgumentNullException(nameof(texture));

            if (func == null)
                throw new ArgumentNullException(nameof(func));

            HRESULT hr;
            if (IntPtr.Size == 8)
            {
                var rc = new _D3DLOCKED_RECT_64();
                hr = texture.LockRect(level, ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        return func(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        texture.UnlockRect(level);
                    }
                }
            }
            else
            {
                var rc = new _D3DLOCKED_RECT_32();
                hr = texture.LockRect(level, ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        return func(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        texture.UnlockRect(level);
                    }
                }
            }
            return default;
        }

        public static HRESULT LockRect(this IDirect3DTexture9 surface, uint level, ref _D3DLOCKED_RECT_64 pLockedRect, IntPtr pRect, uint Flags)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            using (var mem = new ComMemory(pLockedRect))
            {
                var hr = surface.LockRect(level, mem.Pointer, pRect, Flags);
                if (hr.IsSuccess)
                {
                    pLockedRect = mem.ToStructure<_D3DLOCKED_RECT_64>();
                }
                return hr;
            }
        }

        public static HRESULT LockRect(this IDirect3DTexture9 surface, uint level, ref _D3DLOCKED_RECT_32 pLockedRect, IntPtr pRect, uint Flags)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            using (var mem = new ComMemory(pLockedRect))
            {
                var hr = surface.LockRect(level, mem.Pointer, pRect, Flags);
                if (hr.IsSuccess)
                {
                    pLockedRect = mem.ToStructure<_D3DLOCKED_RECT_32>();
                }
                return hr;
            }
        }

        public static HRESULT WithLockRect(this IDirect3DCubeTexture9 texture, _D3DCUBEMAP_FACES faceType, uint level, IntPtr pRect, uint Flags, Action<int, IntPtr> action)
        {
            if (texture == null)
                throw new ArgumentNullException(nameof(texture));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            HRESULT hr;
            if (IntPtr.Size == 8)
            {
                var rc = new _D3DLOCKED_RECT_64();
                hr = texture.LockRect(faceType, level, ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        action(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        texture.UnlockRect(faceType, level);
                    }
                }
            }
            else
            {
                var rc = new _D3DLOCKED_RECT_32();
                hr = texture.LockRect(faceType, level, ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        action(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        texture.UnlockRect(faceType, level);
                    }
                }
            }
            return hr;
        }

        public static T WithLockRect<T>(this IDirect3DCubeTexture9 texture, _D3DCUBEMAP_FACES faceType, uint level, IntPtr pRect, uint Flags, Func<int, IntPtr, T> func)
        {
            if (texture == null)
                throw new ArgumentNullException(nameof(texture));

            if (func == null)
                throw new ArgumentNullException(nameof(func));

            HRESULT hr;
            if (IntPtr.Size == 8)
            {
                var rc = new _D3DLOCKED_RECT_64();
                hr = texture.LockRect(faceType, level, ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        return func(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        texture.UnlockRect(faceType, level);
                    }
                }
            }
            else
            {
                var rc = new _D3DLOCKED_RECT_32();
                hr = texture.LockRect(faceType, level, ref rc, pRect, Flags);
                if (hr.IsSuccess)
                {
                    try
                    {
                        return func(rc.Pitch, rc.pBits);
                    }
                    finally
                    {
                        texture.UnlockRect(faceType, level);
                    }
                }
            }
            return default;
        }

        public static HRESULT LockRect(this IDirect3DCubeTexture9 surface, _D3DCUBEMAP_FACES faceType, uint level, ref _D3DLOCKED_RECT_64 pLockedRect, IntPtr pRect, uint Flags)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            using (var mem = new ComMemory(pLockedRect))
            {
                var hr = surface.LockRect(faceType, level, mem.Pointer, pRect, Flags);
                if (hr.IsSuccess)
                {
                    pLockedRect = mem.ToStructure<_D3DLOCKED_RECT_64>();
                }
                return hr;
            }
        }

        public static HRESULT LockRect(this IDirect3DCubeTexture9 surface, _D3DCUBEMAP_FACES faceType, uint level, ref _D3DLOCKED_RECT_32 pLockedRect, IntPtr pRect, uint Flags)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            using (var mem = new ComMemory(pLockedRect))
            {
                var hr = surface.LockRect(faceType, level, mem.Pointer, pRect, Flags);
                if (hr.IsSuccess)
                {
                    pLockedRect = mem.ToStructure<_D3DLOCKED_RECT_32>();
                }
                return hr;
            }
        }
    }
}
