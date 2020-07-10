using The_Ark.enums;

namespace The_Ark.entities.Natural
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