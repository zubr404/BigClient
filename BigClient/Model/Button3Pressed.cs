using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigClient.Model
{
    /// <summary>
    /// ЛИШНИЙ
    /// </summary>
    class Button3Pressed : IStateScreens
    {
        ScreensMachine ScreensMachine;

        public Button3Pressed(ScreensMachine screensMachine)
        {
            ScreensMachine = screensMachine;
        }


        public void ClickButton1()
        {
            throw new NotImplementedException();
        }

        public void ClickButton2()
        {
            throw new NotImplementedException();
        }

        public void ClickButton3()
        {
            throw new NotImplementedException();
        }

        public void InsertAnyText(string text)
        {
            throw new NotImplementedException();
        }

        public void InsertSetText(string text)
        {
            throw new NotImplementedException();
        }

        public StatusComponents GetStatusComponents()
        {
            throw new NotImplementedException();
        }

    }
}
