using BigClient.Model;
using System.Windows;

namespace BigClient.ViewModel
{
    class ViewModelScreens : PropertyChangedBase, IStatusComponent
    {
        ScreensMachine ScreensMachine;
        IStateScreens stateScreens;

        public ViewModelScreens()
        {
            ScreensMachine = new ScreensMachine();
            stateScreens = ScreensMachine.GetState();
            UpdateState();
        }

        // обновление состояний Экранов
        private void UpdateState()
        {
            IsActiveButton1 = stateScreens.GetStatusComponents().IsActiveButton1;
            IsActiveButton2 = stateScreens.GetStatusComponents().IsActiveButton2;
            IsActiveButton3 = stateScreens.GetStatusComponents().IsActiveButton3;
            IsActiveScreen1 = stateScreens.GetStatusComponents().IsActiveScreen1;
            IsActiveScreen2 = stateScreens.GetStatusComponents().IsActiveScreen2;
            Text = stateScreens.GetStatusComponents().Text;
        }

        #region - Commands
        // нажатие Кнопки1
        private RelayCommand clickButton1;
        public RelayCommand ClickButton1 => clickButton1 ?? (clickButton1 = new RelayCommand(Button1Pressed));

        private void Button1Pressed(object arg)
        {
            stateScreens = ScreensMachine.Button1Pressed();
            UpdateState();
        }

        // нажатие Кнопки2
        private RelayCommand clickButton2;
        public RelayCommand ClickButton2 => clickButton2 ?? (clickButton2 = new RelayCommand(Button2Pressed));

        private void Button2Pressed(object arg)
        {
            stateScreens = ScreensMachine.Button2Pressed();
            UpdateState();
        }

        // нажатие Кнопки3
        private RelayCommand clickButton3;
        public RelayCommand ClickButton3 => clickButton3 ?? (clickButton3 = new RelayCommand(Button3Pressed));

        private void Button3Pressed(object arg)
        {
            stateScreens = ScreensMachine.Button3Pressed();
            UpdateState();
        }

        // ввод текста
        private RelayCommand insertText;
        public RelayCommand InsertText => insertText ?? (insertText = new RelayCommand(EnteredText));

        private void EnteredText(object arg)
        {
            string text = arg.ToString();
            stateScreens = ScreensMachine.EnteredText(text);
            UpdateState();
        }
        #endregion

        #region - Implement IStatusComponent
        // активность Кнопки1
        bool isActiveButton1;
        public bool IsActiveButton1
        {
            get { return isActiveButton1; }
            set
            {
                isActiveButton1 = value;
                base.NotifyPropertyChanged();
            }
        }

        // активность Кнопки2
        bool isActiveButton2;
        public bool IsActiveButton2
        {
            get { return isActiveButton2; }
            set
            {
                isActiveButton2 = value;
                base.NotifyPropertyChanged();
            }
        }

        // активность Кнопки3
        bool isActiveButton3;
        public bool IsActiveButton3
        {
            get { return isActiveButton3; }
            set
            {
                isActiveButton3 = value;
                base.NotifyPropertyChanged();
            }
        }

        // активность Экрана1
        Visibility isActiveScreen1;
        public Visibility IsActiveScreen1
        {
            get { return isActiveScreen1; }
            set
            {
                isActiveScreen1 = value;
                base.NotifyPropertyChanged();
            }
        }

        // активность Экрана1
        Visibility isActiveScreen2;
        public Visibility IsActiveScreen2
        {
            get { return isActiveScreen2; }
            set
            {
                isActiveScreen2 = value;
                base.NotifyPropertyChanged();
            }
        }

        // текст №1
        string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                base.NotifyPropertyChanged();
            }
        }
        #endregion
    }
}
