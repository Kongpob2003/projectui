using Mauiv2.page;
using Microsoft.Maui.Controls;

namespace MyApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // ฟังก์ชันเมื่อกดปุ่ม "เข้าสู่ระบบ"
        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new HomePage());
        }

        // ฟังก์ชันเมื่อกดลิงก์ "สมัครสมาชิก"
        // private async void OnSignUpLabelTapped(object sender, EventArgs e)
        // {
        //     // นำทางไปยังหน้า RegisterPage (คุณสามารถสร้างหน้า RegisterPage ได้เพิ่มเติม)
        //     await Navigation.PushAsync(new RegisterPage());
        // }
    }
}
