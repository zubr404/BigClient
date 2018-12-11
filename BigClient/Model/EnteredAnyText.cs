using System.Windows;

namespace BigClient.Model
{
    class EnteredAnyText : IStateScreens
    {
        ScreensMachine ScreensMachine;
        IStatusComponent statusComponents;

        public EnteredAnyText(ScreensMachine screensMachine)
        {
            ScreensMachine = screensMachine;
            statusComponents = new StatusComponents
            {
                IsActiveButton1 = false,
                IsActiveButton2 = false,
                IsActiveButton3 = false,
                IsActiveScreen1 = Visibility.Collapsed,
                IsActiveScreen2 = Visibility.Visible,
                Text = "hi"
            };
        }

        public void ClickButton1()
        {
            
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
            ScreensMachine.SetState(ScreensMachine.GetEnteredSetText());
        }

        public IStatusComponent GetStatusComponents() { return statusComponents; }
    }
}
