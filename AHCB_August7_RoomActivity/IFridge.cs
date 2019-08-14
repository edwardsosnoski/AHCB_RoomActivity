using System;
namespace AHCB_August7_RoomActivity
{
    public interface IFridge
    {
        void Contents(Grocery grocery);
        string GetContents();
    }
}
