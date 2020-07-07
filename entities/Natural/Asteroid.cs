namespace The_Ark
{
    public class Asteroid : Harmful
    {
        public SizeType size;
        public Asteroid(int size)
        {
            this.size = (SizeType)size;
        }
    }
}