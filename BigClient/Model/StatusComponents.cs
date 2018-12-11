using System.Windows;

namespace BigClient.Model
{
    struct StatusComponents: IStatusComponent
    {
        public bool IsActiveButton1 { get; set; }
        public bool IsActiveButton2 { get; set; }
        public bool IsActiveButton3 { get; set; }
        public Visibility IsActiveScreen1 { get; set; }
        public Visibility IsActiveScreen2 { get; set; }
        public string Text { get; set; }
    }
}
