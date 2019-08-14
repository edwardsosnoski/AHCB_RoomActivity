using System;
namespace AHCB_August7_RoomActivity
{
    public class KenmoreOven : IOven
    {
        public string Cook(Food food)
        {
            return $"You should cook {food.Name} at {food.CookingTemp}";
        }
    }
}