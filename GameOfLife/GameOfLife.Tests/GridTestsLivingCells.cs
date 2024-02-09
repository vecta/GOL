namespace GameOfLife.Tests;

public class GridTestsLivingCells
{
    [Test]
    public void DeadCellWith0NeighboursStaysDead()
    {
        IGrid grid = new Grid(3, 3, new List<Cell>());
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith1NeighbourStaysDead()
    {
        List<Cell> liveCells = [new Cell(1, 2)];

        var grid = new Grid(3, 3, liveCells);
        grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith2NeighboursStaysDead()
    {
        List<Cell> liveCells = [new Cell(1, 2), new Cell(2, 3)];

        IGrid grid = new Grid(3, 3, liveCells);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith3NeighboursComesAlive()
    {
        List<Cell> liveCells = [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3)];

        IGrid grid = new Grid(3, 3, liveCells);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.True);
    }

    [Test]
    public void DeadCellWith4NeighboursStaysDead()
    {
        List<Cell> liveCells = [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 3)];

        IGrid grid = new Grid(3, 3, liveCells);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith5NeighboursStaysDead()
    {
        List<Cell> liveCells = [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 3)];

        IGrid grid = new Grid(3, 3, liveCells);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith6NeighboursStaysDead()
    {
        List<Cell> liveCells =
            [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 3), new Cell(3, 1)];

        IGrid grid = new Grid(3, 3, liveCells);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith7NeighboursStaysDead()
    {
        List<Cell> liveCells =
        [
            new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 3), new Cell(3, 1),
            new Cell(3, 2)
        ];

        IGrid grid = new Grid(3, 3, liveCells);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith8NeighboursStaysDead()
    {
        List<Cell> liveCells =
        [
            new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 3), new Cell(3, 1),
            new Cell(3, 2), new Cell(3, 3)
        ];

        IGrid grid = new Grid(3, 3, liveCells);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }
}