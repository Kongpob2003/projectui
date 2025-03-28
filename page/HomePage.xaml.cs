using Mauiv2.page.Mauiv2;

namespace Mauiv2.page
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            LoadUserData(); // เรียกฟังก์ชันเพื่อโหลดข้อมูลผู้ใช้
        }

        private void LoadUserData()
        {
            // แสดงชื่อผู้ใช้
            usernameLabel.Text = UserSession.Username; 

            // ตั้งค่ารูปภาพโปรไฟล์
            if (!string.IsNullOrEmpty(UserSession.ProfileImage))
            {
                profileImage.Source = UserSession.ProfileImage; 
            }
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(page: new RegisterPage());
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(page: new DeletePage());
        }

        private async void OnViewRegistrationInfoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationInfoPage());
        }

        private async void OnProfileImageTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }
    }
    namespace Mauiv2
{
    public static class UserSession
    {
        public static string Username { get; set; }
        public static string ProfileImage { get; set; } // เก็บชื่อไฟล์หรือ URL ของรูปโปรไฟล์
    }
}

}
