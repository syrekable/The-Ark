namespace The_Ark.entities.SpaceShip
{
    public struct Database
    {
        
        //Todo - w przypadku uzycia jak payload/systems zmienic na partial class
        public Database(int scientific, int cultural)
        {
            Scientific = scientific;
            Cultural = cultural;
        }
        public int Scientific { get; private set; }
        public int Cultural { get; private set; }
    }
}