using System;
using System.Linq;
using System.Windows.Forms;

namespace DirectN.WinTemp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //_swapChain = new Lazy<ComObject<IDXGISwapChain>>(CreateSwapChain);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
        }

//        private ComObject<ID3D11Device> CreateD3D11Device()
//        {
//            return D3D11Functions.D3D11CreateDevice(
//                D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT |
//#if DEBUG
//                D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG |
//#endif
//                D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_VIDEO_SUPPORT);
//        }

//        private ComObject<IDXGIFactory1> CreateFactory()
//        {
//            return _adapter.Value.GetParent<IDXGIFactory1>();
//        }

//        private ComObject<IDXGIAdapter> CreateAdapter()
//        {
//            return _device.Value.GetAdapter();
//        }

//        private ComObject<IDXGIOutput> CreateOutput()
//        {
//            return _adapter.Value.EnumOutputs<IDXGIOutput>().First();
//        }

//        private ComObject<IDXGIDevice> CreateDevice()
//        {
//            return _d3d11device.Value.ToDevice<IDXGIDevice>();
//        }

//        private ComObject<IDXGISwapChain> CreateSwapChain()
//        {
//            var desc = new DXGI_SWAP_CHAIN_DESC();
//            desc.BufferCount = 2;
//            desc.BufferDesc.Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM;
//            desc.BufferDesc.Width = (uint)Width;
//            desc.BufferDesc.Height = (uint)Height;
//            desc.BufferUsage = Constants.DXGI_USAGE_RENDER_TARGET_OUTPUT;
//            desc.SwapEffect = DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL;
//            desc.Windowed = true;
//            desc.OutputWindow = Handle;
//            desc.Flags = 0;
//            desc.SampleDesc.Count = 1;
//            desc.SampleDesc.Quality = 0;
//            return _device.Value.CreateSwapChain<IDXGISwapChain>(desc);
//        }
    }
}
