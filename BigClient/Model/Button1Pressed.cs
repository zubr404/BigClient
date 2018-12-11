using System.Windows;

namespace BigClient.Model
{
    class Button1Pressed : IStateScreens
    {
        ScreensMachine ScreensMachine;
        IStatusComponent statusComponents;

        public Button1Pressed(ScreensMachine screensMachine)
        {
            ScreensMachine = screensMachine;
            statusComponents = new StatusComponents
            {
                IsActiveButton1 = true,
                IsActiveButton2 = true,
                IsActiveButton3 = false,
                IsActiveScreen1 = Visibility.Visible,
                IsActiveScreen2 = Visibility.Collapsed,
                Text = string.Empty
            };
        }

        public void ClickButton1()
        {
            System.Windows.MessageBox.Show("Кнопка1 уже была нажата.");
        }

        public void ClickButton2()
        {
            ScreensMachine.SetState(ScreensMachine.GetButton2Pressed());
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
