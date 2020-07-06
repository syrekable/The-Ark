namespace The_Ark
{
    public struct Database
    {
        public Database(int scientific, int cultural)
        {
            this.scientific = scientific;
            this.cultural = cultural;
        }
        public int scientific { get; private set; }
        public int cultural { get; private set; }
    }
}