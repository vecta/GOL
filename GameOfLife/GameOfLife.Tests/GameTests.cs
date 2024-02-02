namespace GameOfLife.Tests;

public class GameTests
{
    [Test]
    public void DeadCellWith0NeighboursStaysDead()
    {
        var game = new Game(3, 3, new());
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith1NeighbourStaysDead()
    {
        List<Cell> liveCells = [new(1, 2)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith2NeighboursStaysDead()
    {
        List<Cell> liveCells = [new(1, 2), new(2, 3)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith3NeighboursComesAlive()
    {
        List<Cell> liveCells = [new(1, 1), new(1, 2), new(1, 3)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.True);
    }

    [Test]
    public void DeadCellWith4NeighboursStaysDead()
    {
        List<Cell> liveCells = [new(1, 1), new(1, 2), new(1, 3), new(2, 3)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }
}
