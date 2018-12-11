using System.Windows;

namespace BigClient.Model
{
    /// <summary>
    /// Состояние компонентов экранов
    /// </summary>
    interface IStatusComponent
    {
        bool IsActiveButton1 { get; set; }
        bool IsActiveButton2 { get; set; }
        bool IsActiveButton3 { get; set; }
        Visibility IsActiveScreen1 { get; set; }
        Visibility IsActiveScreen2 { get; set; }
        string Text { get; set; }
    }
}
