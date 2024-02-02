namespace GameOfLife.Tests
{
    public class GameTests
    {
        [Test]
        public void DeadCellWith0NeighboursStaysDead()
        {
            var game = new Game(3, 3);
            game.Evolve();
            Assert.That(game.IsCellAlive(1,1));
        }
    }

    public class Game
    {
        public Game(int rows, int columns)
        {

        }

        public void Evolve() { throw new NotImplementedException(); }
        public bool IsCellAlive(int row, int column) { throw new NotImplementedException(); }
    }
}