namespace GameOfLife.Tests;

public class GameTests
{
    [Test]
    public void DeadCellWith0NeighboursStaysDead()
    {
        var game = new Game(3, 3);
        game.Evolve();
        Assert.That(game.IsCellAlive(1, 1), Is.False);
    }

    [Test]
    public void DeadCellWith1NeighboursStaysDead()
    {
        Tuple<int, int>[] liveCells = [new(0, 1)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(1, 1), Is.False);
    }
}
