namespace GameOfLife;

public class GameRule
{
    public static Tuple<int, int>[] Apply(Tuple<int, int>[] liveCells)
    {
        List<Tuple<int, int>> cellList = liveCells.ToList();


        foreach (Tuple<int, int> cell in cellList)
        {
            //if(cell.Item1 != 1)
        }
        cellList.Add(new(2, 2));
        
        return cellList.ToArray();
    }
}
