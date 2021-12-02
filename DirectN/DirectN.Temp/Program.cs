using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DirectN.Temp
{
    class Program
    {
        static void Main()
        {
            // capture 10 shots and saves them as PNG
            // this is a C# port of https://stackoverflow.com/a/30138664/403671

            Direct3D9TakeScreenshots(Constants.D3DADAPTER_DEFAULT, 10).ThrowOnError();
        }

        static HRESULT Direct3D9TakeScreenshots(uint adapter, int count)
        {
            using (var d3d = new ComObject<IDirect3D9>(Functions.Direct3DCreate9(Constants.D3D_SDK_VERSION)))
            {
                var mode = new _D3DDISPLAYMODE();
                d3d.Object.GetAdapterDisplayMode(adapter, ref mode).ThrowOnError();

                var parameters = new _D3DPRESENT_PARAMETERS_
                {
                    Windowed = true,
                    BackBufferCount = 1,
                    BackBufferHeight = mode.Height,
                    BackBufferWidth = mode.Width,
                    SwapEffect = _D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD
                };

                d3d.Object.CreateDevice(adapter, _D3DDEVTYPE.D3DDEVTYPE_HAL, IntPtr.Zero, Constants.D3DCREATE_SOFTWARE_VERTEXPROCESSING, ref parameters, out var dev).ThrowOnError();
                using (var device = new ComObject<IDirect3DDevice9>(dev))
                {
                    dev.CreateOffscreenPlainSurface(mode.Width, mode.Height, _D3DFORMAT.D3DFMT_A8R8G8B8, _D3DPOOL.D3DPOOL_SYSTEMMEM, out var surf, IntPtr.Zero).ThrowOnError();
                    using (var surface = new ComObject<IDirect3DSurface9>(surf))
                    {
                        var rc = new _D3DLOCKED_RECT();
                        surf.LockRect(ref rc, IntPtr.Zero, 0).ThrowOnError();
                        var pitch = rc.Pitch;
                        surf.UnlockRect();

                        var shots = new byte[count][];
                        for (var i = 0; i < count; i++)
                        {
                            shots[i] = new byte[pitch * mode.Height];
                        }

                        var sw = new Stopwatch();
                        sw.Start();
                        for (var i = 0; i < count; i++)
                        {
                            dev.GetFrontBufferData(0, surf).ThrowOnError();
                            surf.LockRect(ref rc, IntPtr.Zero, 0).ThrowOnError();
                            Marshal.Copy(rc.pBits, shots[i], 0, shots[i].Length);
                            surf.UnlockRect().ThrowOnError();
                        }
                        Console.WriteLine("Elapsed: " + sw.Elapsed);

                        for (var i = 0; i < count; i++)
                        {
                            SavePixelsToFile32bppPBGRA(mode.Width, mode.Height, (uint)pitch, shots[i], "cap" + i + ".png", WICConstants.GUID_ContainerFormatPng).ThrowOnError();
                        }
                    }
                }
            }
            return 0;
        }

        static HRESULT SavePixelsToFile32bppPBGRA(uint width, uint height, uint stride, byte[] pixels, string filePath, Guid format)
        {
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            using (var fac = new ComObject<IWICImagingFactory>((IWICImagingFactory)new WicImagingFactory()))
            {
                fac.Object.CreateStream(out var stream).ThrowOnError();
                using (new ComObject<IWICStream>(stream))
                {
                    const int GENERIC_WRITE = 0x40000000;
                    stream.InitializeFromFilename(filePath, GENERIC_WRITE).ThrowOnError();
                    fac.Object.CreateEncoder(format, IntPtr.Zero, out var encoder).ThrowOnError();
                    using (new ComObject<IWICBitmapEncoder>(encoder))
                    {
                        encoder.Initialize(stream, WICBitmapEncoderCacheOption.WICBitmapEncoderNoCache).ThrowOnError();
                        encoder.CreateNewFrame(out var frame, out var bag).ThrowOnError();
                        using (new ComObject<IWICBitmapFrameEncode>(frame))
                        {
                            frame.Initialize(null).ThrowOnError();
                            frame.SetSize(width, height).ThrowOnError();
                            frame.SetPixelFormat(ref format).ThrowOnError();
                            frame.WritePixels(height, stride, (int)(stride * height), pixels).ThrowOnError();
                            frame.Commit().ThrowOnError();
                            encoder.Commit().ThrowOnError();
                        }
                    }
                }
            }
            return 0;
        }
    }
}
