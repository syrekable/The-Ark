namespace The_Ark
{
    public struct Payload
    {
        public Payload(int colonists, int scientificDatabase, int culturalDatabase)
        {
            this.colonists = colonists;
            database = new Database(scientificDatabase, culturalDatabase);
        }

        public int colonists { get; private set; }
        public Database database { get; private set; }
        public override string ToString()
        {
            return $"Colonists:\t{colonists}\nDatabase integrity:\n-scientific:\t{database.scientific}\n-cultural:\t{database.cultural}";
        }
    }
}

