namespace GameOfLife.Tests;

public class GameTestsLivingCells
{
    [Test]
    public void DeadCellWith0NeighboursStaysDead()
    {
        var game = new Game(3, 3, new List<Cell>());
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith1NeighbourStaysDead()
    {
        List<Cell> liveCells = [new Cell(1, 2)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith2NeighboursStaysDead()
    {
        List<Cell> liveCells = [new Cell(1, 2), new Cell(2, 3)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith3NeighboursComesAlive()
    {
        List<Cell> liveCells = [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.True);
    }

    [Test]
    public void DeadCellWith4NeighboursStaysDead()
    {
        List<Cell> liveCells = [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 3)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith5NeighboursStaysDead()
    {
        List<Cell> liveCells = [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 3)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith6NeighboursStaysDead()
    {
        List<Cell> liveCells =
            [new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 3), new Cell(3, 1)];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith7NeighboursStaysDead()
    {
        List<Cell> liveCells =
        [
            new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 3), new Cell(3, 1),
            new Cell(3, 2)
        ];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }

    [Test]
    public void DeadCellWith8NeighboursStaysDead()
    {
        List<Cell> liveCells =
        [
            new Cell(1, 1), new Cell(1, 2), new Cell(1, 3), new Cell(2, 1), new Cell(2, 3), new Cell(3, 1),
            new Cell(3, 2), new Cell(3, 3)
        ];

        var game = new Game(3, 3, liveCells);
        game.Evolve();
        Assert.That(game.IsCellAlive(2, 2), Is.False);
    }
}