namespace DirectN
{
    public partial struct tagPOINT
    {
        public tagPOINT(uint x, uint y)
        {
            this.x = (int)x;
            this.y = (int)y;
        }

        public tagPOINT(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => "X=" + x + ",Y=" + y;
    }
}
