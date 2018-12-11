namespace BigClient.Model
{
    /// <summary>
    /// Содержит все действия
    /// </summary>
    interface IStateScreens
    {
        void ClickButton1();                // Нажатие Кнопки1        
        void ClickButton2();                // Нажатие Кнопки2        
        void ClickButton3();                // Нажатие Кнопки3        
        void InsertAnyText(string text);    // Ввод любого текста в Поле1        
        void InsertSetText(string text);    // Ввод установленного текста в Поле1        
        IStatusComponent GetStatusComponents(); // Получение статуса компонентов
    }
}
