namespace GameOfLife
{
    public interface IGrid
    {
        public IGrid Evolve();
        bool IsCellAlive(int row, int column);
        bool IsDead();
    }
}
