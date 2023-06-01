namespace Csharp
{
    public class Menu
    {
        protected int menuIndex;
        protected string menuName;
        protected string[] menuFunction;
        protected Action menuEvent;

        public string MenuName => menuName;

        public Menu(int menuIndex, string menuName, Action menuEvent)
        {
            this.menuIndex = menuIndex;
            this.menuName = menuName;
            this.menuEvent = menuEvent;

            InitiateFunction();
        }

        private void InitiateFunction()
        {
            menuFunction = new string[5];
            menuFunction[0] = "1. Show all";
            menuFunction[1] = "2. Update";
            menuFunction[2] = "3. Add";
            menuFunction[3] = "4. Sell";
            menuFunction[4] = "0. Back";
        }

        public void UIMenu()
        {
            Console.WriteLine($"{GameUtilities.FirstName(this.menuName)} manager menu:");

            GameUtilities.ShowLine(20);

            for (int i = 0; i < menuFunction.Length - 1; i++)
                Console.WriteLine($"{menuFunction[i]} {GameUtilities.FirstName(this.menuName)}");
            Console.WriteLine(menuFunction[menuFunction.Length-1]);

            GameUtilities.ShowLine(20);

            Console.WriteLine("Enter selection: ");
        }
    }

    public class GameUIManager
    {
        public Menu[] menus;

        public GameUIManager()
        {
            menus = new Menu[4];
            menus[0] = new Menu(1, "Weapons Manger", null);
            menus[1] = new Menu(2, "Cloths Manger", null);
            menus[2] = new Menu(3, "Inventory Manger", null);
            menus[3] = new Menu(4, "Inventory Information", null);
        }

        public void ShowMenu()
        {
            Console.WriteLine("Inventory Manager Program");
            GameUtilities.ShowLine(20);
            for (int i = 0; i < menus.Length; i++)
                Console.WriteLine($"{i+1}. {menus[i].MenuName}.");
            GameUtilities.ShowLine(20);
            Console.Write("Enter selection: ");
            int key = int.Parse(Console.ReadLine());
        }
    }
}
