using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class clsTicTacToe
    {

        public bool toggleValue = true;
        string userOne = "O", userTwo="X";


        public void setUserOne(string val)
        {
            userOne = val;
        }

        public void setUserTwo(string val)
        {
            userTwo = val;
        }

        public string getUserOne()
        {
            return userOne;
        }

        public string getUserTwo()
        {
            return userTwo;
        }


        public void setToggleValue()
        {
            toggleValue = (toggleValue) ?false:true;
           
        }

        public bool getToggleValue()
        {
            return toggleValue;
        }


    }
}
