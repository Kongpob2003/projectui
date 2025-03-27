using Microsoft.Maui.Controls;
using MyApp;

namespace Mauiv2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        // ตั้งค่าให้แสดงหน้า LoginPage ทันทีเมื่อเปิดแอป และรองรับ nullability
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new LoginPage()));  
        }
    }
}
