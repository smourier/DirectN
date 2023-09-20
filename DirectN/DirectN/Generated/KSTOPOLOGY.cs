// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSTOPOLOGY
    {
        public uint CategoriesCount;
        public IntPtr Categories;
        public uint TopologyNodesCount;
        public IntPtr TopologyNodes;
        public uint TopologyConnectionsCount;
        public IntPtr TopologyConnections;
        public IntPtr TopologyNodesNames;
        public uint Reserved;
    }
}
