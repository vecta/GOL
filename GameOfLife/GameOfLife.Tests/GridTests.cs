namespace GameOfLife.Tests;

public class GridTests
{
    [Test]
    public void IsDeadReturnsTrueIfNoLivingCells()
    {
        IGrid grid = new Grid(3, 3, []);
        Assert.That(grid.IsDead(), Is.True);
    }
}
