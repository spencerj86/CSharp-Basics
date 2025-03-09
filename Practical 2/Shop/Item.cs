//=============================================================================
// Program's Item class
//=============================================================================

namespace Shop
{
    // TODO: Write a class called Item that contains 2 data members:
    //       A string called name and an int called cost.
    //       This class should have a default constructor that sets name to ""
    //       and cost to 0.
    //       It should also have an overloaded constructor that accepts 2
    //       parameters - a string and an int.
    //
    //       Write getters/accessors for each data member. They should be called
    //       GetName and GetCost.
    //
    //       Write setters/mutators for each data member. They should be called
    //       SetName and SetCost.
    public class Item
    {
        private string title;
        private int amount;
        
        public Item()
        {
            title = "";
            amount = 0;
        }
        public Item(string name, int cost)
        {
            title = name;
            amount = cost;
        }
        public string GetName()
        {
            return title;
        }
        public int GetCost()
        {
            return amount;
        }
        public void SetName(string name)
        {
            name = title;
        }
        public void SetCost(int cost)
        {
            amount = cost;
        }
    }
}
