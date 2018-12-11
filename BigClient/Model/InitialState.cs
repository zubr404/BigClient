using System.Windows;

namespace BigClient.Model
{
    class InitialState : IStateScreens
    {
        ScreensMachine ScreensMachine;
        IStatusComponent statusComponents;

        public InitialState(ScreensMachine screensMachine)
        {
            ScreensMachine = screensMachine;
            statusComponents = new StatusComponents
            {
                IsActiveButton1 = true,
                IsActiveButton2 = false,
                IsActiveButton3 = false,
                IsActiveScreen1 = Visibility.Visible,
                IsActiveScreen2 = Visibility.Collapsed,
                Text = string.Empty
            };
        }

        public void ClickButton1()
        {
            ScreensMachine.SetState(ScreensMachine.GetButton1Pressed());
        }

        public void ClickButton2()
        {
            
        }

        public void ClickButton3()
        {
            
        }

        public void InsertAnyText(string text)
        {
            
        }

        public void InsertSetText(string text)
        {
            
        }

        public IStatusComponent GetStatusComponents() { return statusComponents; }
    }
}
