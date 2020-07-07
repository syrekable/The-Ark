﻿namespace The_Ark
{
	public class SpaceShip : Entity
	{
		public Payload payload { get; private set; }
		public Systems systems { get; private set; }
		public SpaceShip(string name)
		{
			//default game mode
			this.name = name;
			payload = new Payload(1000, 100, 100);
			systems = new Systems(100, 100);
		}

		public SpaceShip(string name, params int[] payloadAndSystems)
        {
			//constructor for various difficulty levels
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
