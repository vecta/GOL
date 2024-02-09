using Moq;

namespace GameOfLife.Tests;

public class GameTests
{
    [Test]
    public void GameStopsAfterGivenNumberOfIterations()
    {
        var grid = new Mock<IGrid>();
        grid.Setup(g => g.Evolve()).Returns(grid.Object);
        var game = new Game(grid.Object);
        game.Start(6);
        grid.Verify(g => g.Evolve(), Times.Exactly(6));
    }

    [Test]
    public void GameStopsIfBoardBecomesEmpty()
    {
        var evolution1 = new Mock<IGrid>();
        var evolution2 = new Mock<IGrid>();
        evolution1.Setup(g => g.Evolve()).Returns(evolution2.Object);
        evolution1.Setup(grid => grid.IsDead()).Returns(false);
        evolution2.Setup(grid => grid.IsDead()).Returns(true);
        var game = new Game(evolution1.Object);
        game.Start(6);
        evolution1.Verify(g => g.Evolve(), Times.Exactly(1));
        evolution2.Verify(g => g.Evolve(), Times.Never);
    }

    [Test]
    public void GameStopsIfCurrentAndPreviousIterationsAreEqual()
    {
        var evolution1 = new Mock<IGrid>();
        var evolution2 = new Mock<IGrid>();
        evolution1.Setup(g => g.Evolve()).Returns(evolution2.Object);
        evolution2.Setup(grid => grid.Equals(evolution1.Object)).Returns(true);

        var game = new Game(evolution1.Object);
        game.Start(6);

        evolution1.Verify(g => g.Evolve(), Times.Once);
    }
}