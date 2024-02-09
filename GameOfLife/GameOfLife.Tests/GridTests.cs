namespace GameOfLife.Tests;

public class GridTests
{
    [Test]
    public void IsDeadReturnsTrueIfNoLivingCells()
    {
        IGrid grid = new Grid(3, 3, []);
        Assert.That(grid.IsDead(), Is.True);
    }

    [Test]
    public void IsDeadReturnsFalseIfGridHasLivingCells()
    {
        IGrid grid = new Grid(3, 3, [new Cell(1, 1)]);
        Assert.That(grid.IsDead(), Is.False);
    }
}
