namespace GameOfLife;

public class Game(IGrid grid)
{
    public void Start(int iterationCount)
    {
        for (var iteration = 1; iteration <= iterationCount; iteration++)
        {
            grid = grid.Evolve();
        }
    }
}