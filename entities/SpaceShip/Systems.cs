namespace The_Ark.entities.SpaceShip
{
    public partial class SpaceShip
    {
        private int _hull;
        private int _lifeSupport;
        
        private void ApplySystems(int hull, int lifeSupport)
        {
            this._hull = hull;
            this._lifeSupport = lifeSupport;
        }

        public string SystemsToString() => $"Hull integrity:\t{_hull}%\nLife support:\t{_lifeSupport}%";
    }
}