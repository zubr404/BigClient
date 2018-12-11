namespace BigClient.Model
{
    class ScreensMachine
    {
        const string SET_TEXT = "hello";

        // все возможные состояния
        IStateScreens initialState;
        IStateScreens button1Pressed;
        IStateScreens button2Pressed;
        IStateScreens enteredAnyText;
        IStateScreens enteredSetText;

        IStateScreens state;

        public ScreensMachine()
        {
            initialState = new CreatorInitialState().CreateState(this);
            button1Pressed = new CreatorButton1PressedState().CreateState(this);
            button2Pressed = new CreatorButton2PressedState().CreateState(this);
            enteredAnyText = new CreatorEnteredAnyTextState().CreateState(this);
            enteredSetText = new CreatorEnteredSetTextState().CreateState(this);

            state = initialState;
        }

        public IStateScreens Button1Pressed()
        {
            state.ClickButton1();
            return state;
        }
        public IStateScreens Button2Pressed()
        {
            state.ClickButton2();
            return state;
        }
        public IStateScreens Button3Pressed()
        {
            state.ClickButton3();
            return state;
        }
        public IStateScreens EnteredText(string text)
        {
            if (text == SET_TEXT)
            {
                state.InsertSetText(text);
                return state;
            }
            else
            {
                state.InsertAnyText(text);
                return state;
            }
        }

        public void SetState(IStateScreens stateScreens)
        {
            state = stateScreens;
        }

        public IStateScreens GetState()
        {
            return state;
        }

        public IStateScreens GetInitialState() { return initialState; }
        public IStateScreens GetButton1Pressed() { return button1Pressed; }
        public IStateScreens GetButton2Pressed() { return button2Pressed; }
        public IStateScreens GetEnteredAnyText() { return enteredAnyText; }
        public IStateScreens GetEnteredSetText() { return enteredSetText; }
    }
}
