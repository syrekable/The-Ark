namespace The_Ark
{
    public struct Systems
    {
        public int hull;
        public int lifeSupport;
        public Systems(int hull, int lifeSupport)
        {
            this.hull = hull;
            this.lifeSupport = lifeSupport;
        }

        public override string ToString()
        {
            return $"Hull integrity:\t{hull}%\nLife support:\t{lifeSupport}%";
        }
    }
}