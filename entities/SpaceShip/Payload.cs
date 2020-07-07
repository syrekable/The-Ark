namespace The_Ark.entities.SpaceShip
{
    public partial class SpaceShip
    {
        
        private int Colonists { get; set; }
        private Database Database { get; set; }
        private void ApplyPayload(int colonists, int scientificDatabase, int culturalDatabase)
        {
            Colonists = colonists;
            Database = new Database(scientificDatabase, culturalDatabase);
        }
        public string PayloadToString() => $"Colonists:\t{Colonists}\nDatabase integrity:\n-scientific:\t{Database.Scientific}%\n-cultural:\t{Database.Cultural}%";
    }
}

