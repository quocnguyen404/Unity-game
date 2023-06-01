using Csharp;

class Program
{
    static void Main()
    {
        List<Item> tempItems = new List<Item>();

        //generate 10 random items
        for (int i = 0; i < 10; i++)
        {
            tempItems.Add(GameUtilities.GetRandomItem());
        }

        GameUIManager UIMenu = new GameUIManager();

        UIMenu.ShowMenu();
    }
}