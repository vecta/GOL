namespace GameOfLife.Tests;

public class GameTests
{
    [Test]
    public void DeadCellWith0NeighboursStaysDead()
    {
        var game = new Game(3, 3);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith1NeighbourStaysDead()
    {
        Tuple<int, int>[] liveCells = [new(1, 2)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }
    [Test]
    public void DeadCellWith2NeighboursStaysDead()
    {
        Tuple<int, int>[] liveCells = [new(1, 2), new(2, 3)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }
    [Test]
    public void DeadCellWith3NeighboursComesAlive()
    {
        Tuple<int, int>[] liveCells = [new(1, 1), new(1, 2), new(1, 3)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.True);
    }
}
