namespace GameOfLife.Tests;

public class GameTestsDeadCells
{
    [Test]
    public void LivingCellWith0NeighboursDies()
    {
        var game = new Game(3, 3, [new Cell(2, 2)]);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith1NeighbourDies()
    {
        var game = new Game(3, 3, [new Cell(1, 2), new Cell(2, 2)]);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith2NeighbourLives()
    {
        var game = new Game(3, 3, [new Cell(1, 2), new Cell(2, 2), new Cell(2, 3)]);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.True);
    }

}