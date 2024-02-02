namespace GameOfLife;

public class Game(int rows, int columns, List<Cell> liveCells)
{
    public void Evolve()
    {
        List<Cell> newLiveCells = new();

        for (int row = 1; row <= rows; row++)
        {
            for (int column = 1; column <= columns; column++)
            {
                int liveNeighbours = GetNeighbourCount(row, column);

                if (liveNeighbours == 3) newLiveCells.Add(new(row, column));
            }
        }

        liveCells = newLiveCells;
    }

    private int GetNeighbourCount(int row, int column)
    {
        int liveNeighbours = 0;
        foreach (var cell in liveCells)
        {
            if ((cell.Row == row) && (cell.Column == column)) continue;
            if ((cell.Row <= row + 1) && (cell.Row >= row - 1) && (cell.Column <= column + 1) && (cell.Column >= column - 1)) liveNeighbours++;
        }
        return liveNeighbours;
    }

    public bool IsCellAlive(int row, int column)
    {
        return liveCells.Contains(new(row, column));
    }
}