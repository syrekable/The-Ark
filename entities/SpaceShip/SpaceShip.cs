namespace The_Ark.entities.SpaceShip
{
	public partial class SpaceShip : Entity
	{
		public SpaceShip(string name)
		{
			//default game mode
			this.name = name;
			
			ApplyPayload(1000,100,100);
			
			ApplySystems(100,100);
		}

		public SpaceShip(string name, params int[] payloadAndSystems)
        {
			//constructor for various difficulty levels
			this.name = name;
			ApplyPayload(payloadAndSystems[0],payloadAndSystems[1],payloadAndSystems[2]);
			
			ApplySystems(payloadAndSystems[3],payloadAndSystems[4]);
        }

        public override string ToString() => $"\n===\t{name}'s stats.\t===\n{SystemsToString()}\n{PayloadToString()}";
	}
}

