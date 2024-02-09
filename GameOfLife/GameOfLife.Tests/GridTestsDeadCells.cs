namespace GameOfLife.Tests;

public class GridTestsDeadCells
{
    private readonly GameTests _gameTests = new GameTests();

    [Test]
    public void LivingCellWith0NeighboursDies()
    {
        IGrid grid = new Grid(3, 3, [new Cell(2, 2)]);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith1NeighbourDies()
    {
        IGrid grid = new Grid(3, 3, [new Cell(1, 2), new Cell(2, 2)]);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith2NeighbourLives()
    {
        IGrid grid = new Grid(3, 3, [new Cell(1, 2), new Cell(2, 2), new Cell(2, 3)]);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.True);
    }

    [Test]
    public void LivingCellWith3NeighbourLives()
    {
        IGrid grid = new Grid(3, 3, [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 2)]);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.True);
    }

    [Test]
    public void LivingCellWith4NeighbourDies()
    {
        IGrid grid = new Grid(3, 3, [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 2), new Cell(2, 3)]);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith5NeighbourDies()
    {
        IGrid grid = new Grid(3, 3, [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 2), new Cell(2, 3)]);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith6NeighbourDies()
    {
        IGrid grid = new Grid(3, 3, [new Cell(1, 1),
                                  new Cell(1, 2),
                                  new Cell(1, 3),
                                  new Cell(2, 1),
                                  new Cell(2, 2),
                                  new Cell(2, 3),
                                  new Cell(3, 1)]);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith7NeighbourDies()
    {
        IGrid grid = new Grid(3, 3, [new Cell(1, 1),
                                  new Cell(1, 2),
                                  new Cell(1, 3),
                                  new Cell(2, 1),
                                  new Cell(2, 2),
                                  new Cell(2, 3),
                                  new Cell(3, 1),
                                  new Cell(3, 2)]);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith8NeighbourDies()
    {
        IGrid grid = new Grid(3, 3, [new Cell(1, 1),
                                  new Cell(1, 2),
                                  new Cell(1, 3),
                                  new Cell(2, 1),
                                  new Cell(2, 2),
                                  new Cell(2, 3),
                                  new Cell(3, 1),
                                  new Cell(3, 2),
                                  new Cell(3, 3)]);
        grid = grid.Evolve();
        Assert.That(grid.IsCellAlive(2, 2), Is.False);
    }
}