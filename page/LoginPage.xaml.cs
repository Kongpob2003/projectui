using System;
using System.Linq;
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

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string enteredEmail = EmailEntry.Text;
            string enteredPassword = PasswordEntry.Text;

            // ตรวจสอบข้อมูลอีเมลและรหัสผ่านจาก MockUsers
            var user = Mauiv2.page.Viewlogin.MockUsers.FirstOrDefault(u => u.Email == enteredEmail && u.Password == enteredPassword);

            if (user != null)
            {
                await DisplayAlert("สำเร็จ", "เข้าสู่ระบบสำเร็จ!", "ตกลง");
                // เพิ่มการนำทางไปยังหน้าอื่น เช่น HomePage หรือ DashboardPage
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("ล้มเหลว", "อีเมลหรือรหัสผ่านไม่ถูกต้อง", "ลองอีกครั้ง");
            }
        }
    }
}
