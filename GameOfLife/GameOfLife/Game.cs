namespace GameOfLife;

public class Game(IGrid grid)
{
    public void Start(int iterationCount)
    {
        for (var iteration = 1; iteration <= iterationCount; iteration++)
        {
            if (grid.IsDead()) return;
            var newGrid = grid.Evolve();
            if (newGrid.Equals(grid)) return;
            grid = newGrid;
        }
    }
}