namespace The_Ark.entities.SpaceShip
{
    public partial class SpaceShip
    {
        private int _hull;
        private int _lifeSupport;
        
        private void ApplySystems(int hull, int lifeSupport)
        {
            _hull = hull;
            _lifeSupport = lifeSupport;
        }

        public string SystemsToString() => $"Hull integrity:\t{_hull}%\nLife support:\t{_lifeSupport}%";
    }
}