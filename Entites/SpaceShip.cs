using System;

namespace The_Ark
{
	public class SpaceShip
	{
		private string name { get; set; }
		private Payload payload;
		private Systems systems;
		public SpaceShip(string name)
		{
			//default game mode
			this.name = name;
			payload = new Payload(1000, 100, 100);
			systems = new Systems(100, 100);
		}

		public SpaceShip(string name, params int[] payloadAndSystems)
        {
			//various difficulty levels
			this.name = name;
			payload = new Payload(payloadAndSystems[0], payloadAndSystems[1], payloadAndSystems[2]);
			systems = new Systems(payloadAndSystems[3], payloadAndSystems[4]);
        }

        public override string ToString()
        {
			return $"\n===\t{name}'s stats.\t===\n{systems}\n{payload}";
        }
    }
}

