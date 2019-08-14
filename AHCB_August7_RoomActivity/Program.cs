using System;

namespace AHCB_August7_RoomActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            IFridge fridge = new LGFridge();
            fridge.Contents(new Grocery("Cucumber"));
            fridge.Contents(new Grocery("Milk"));
            fridge.Contents(new Grocery("Butter"));
            Console.WriteLine(fridge.GetContents());
        }
    }
}
