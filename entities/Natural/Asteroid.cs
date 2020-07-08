namespace The_Ark
{
    public class Asteroid : Harmful
    {
        private SizeType _size;
        public Asteroid(int size)
        {
            _size = (SizeType)size;
        }
    }
}