using System;
namespace AHCB_August7_RoomActivity
{
    public class Kitchen
    {
        private readonly IOven _oven;
        private readonly IFridge _fridge;

        public Kitchen(IOven oven, IFridge fridge)
        {
            _oven = oven;
            _fridge = fridge;
        }
    }
}