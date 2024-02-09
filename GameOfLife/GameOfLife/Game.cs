namespace GameOfLife;

public class Game(int rows, int columns, List<Cell> liveCells, IGrid grid = null)
{
    public void Evolve()
    {
        List<Cell> newLiveCells = [];

        for (var row = 1; row <= rows; row++)
        {
            for (var column = 1; column <= columns; column++)
            {
                var liveNeighbours = GetNeighbourCount(row, column);

                if ((liveNeighbours == 2 && IsCellAlive(row, column)) || (liveNeighbours == 3))
                    newLiveCells.Add(new Cell(row, column));
            }
        }

        liveCells = newLiveCells;
    }

    public void Start(int iterationCount)
    {

    }

    private int GetNeighbourCount(int row, int column)
    {
        var liveNeighbours = 0;
        foreach (var cell in liveCells)
        {
            if (cell.Row == row && cell.Column == column) continue;
            if (cell.Row <= row + 1 && cell.Row >= row - 1 && cell.Column <= column + 1 && cell.Column >= column - 1) liveNeighbours++;
        }
        return liveNeighbours;
    }

    public bool IsCellAlive(int row, int column)
    {
        return liveCells.Contains(new Cell(row, column));
    }
}