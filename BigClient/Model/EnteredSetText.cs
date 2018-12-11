using System.Windows;

namespace BigClient.Model
{
    class EnteredSetText : IStateScreens
    {
        ScreensMachine ScreensMachine;
        IStatusComponent statusComponents;

        public EnteredSetText(ScreensMachine screensMachine)
        {
            ScreensMachine = screensMachine;
            statusComponents = new StatusComponents
            {
                IsActiveButton1 = false,
                IsActiveButton2 = false,
                IsActiveButton3 = true,
                IsActiveScreen1 = Visibility.Collapsed,
                IsActiveScreen2 = Visibility.Visible,
                Text = "thank you"
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
            ScreensMachine.SetState(ScreensMachine.GetInitialState());
        }

        public void InsertAnyText(string text)
        {
            ScreensMachine.SetState(ScreensMachine.GetEnteredAnyText());
        }

        public void InsertSetText(string text)
        {
            ScreensMachine.SetState(ScreensMachine.GetEnteredSetText());
        }

        public IStatusComponent GetStatusComponents() { return statusComponents; }
    }
}
