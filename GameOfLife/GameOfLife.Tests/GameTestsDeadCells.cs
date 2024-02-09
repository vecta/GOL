using Moq;

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

    [Test]
    public void LivingCellWith3NeighbourLives()
    {
        var game = new Game(3, 3, [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 2)]);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.True);
    }

    [Test]
    public void LivingCellWith4NeighbourDies()
    {
        var game = new Game(3, 3, [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 2), new Cell(2, 3)]);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith5NeighbourDies()
    {
        var game = new Game(3, 3, [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 2), new Cell(2, 3)]);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith6NeighbourDies()
    {
        var game = new Game(3, 3, [new Cell(1, 1),
            new Cell(1, 2),
            new Cell(1, 3),
            new Cell(2, 1),
            new Cell(2, 2),
            new Cell(2, 3),
            new Cell(3, 1)]);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith7NeighbourDies()
    {
        var game = new Game(3, 3, [new Cell(1, 1),
            new Cell(1, 2),
            new Cell(1, 3),
            new Cell(2, 1),
            new Cell(2, 2),
            new Cell(2, 3),
            new Cell(3, 1),
            new Cell(3, 2)]);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void LivingCellWith8NeighbourDies()
    {
        var game = new Game(3, 3, [new Cell(1, 1),
            new Cell(1, 2),
            new Cell(1, 3),
            new Cell(2, 1),
            new Cell(2, 2),
            new Cell(2, 3),
            new Cell(3, 1),
            new Cell(3, 2),
            new Cell(3, 3)]);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void GameStopsAfterGivenNumberOfIterations()
    {
        var grid = new Mock<IGrid>();

        var game = new Game(3, 3, [], grid.Object);
        game.Start(6);
        grid.Verify(g => g.Evolve(), Times.Exactly(6));
    }
}