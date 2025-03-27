namespace Mauiv2.page
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // ฟังก์ชันที่เรียกเมื่อผู้ใช้กดปุ่มลงทะเบียน
        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // ตัวอย่าง: ไปยังหน้าลงทะเบียน (RegisterPage)
            await Navigation.PushAsync(new RegisterPage());
        }

        // ฟังก์ชันที่เรียกเมื่อผู้ใช้กดปุ่มดูข้อมูลการลงทะเบียนเรียน
        private async void OnViewRegistrationInfoClicked(object sender, EventArgs e)
        {
            // ตัวอย่าง: ไปยังหน้าดูข้อมูลการลงทะเบียนเรียน (RegistrationInfoPage)
            await Navigation.PushAsync(new RegistrationInfoPage());
        }

        private async void OnProfileImageTapped(object sender, EventArgs e)
        {
            // นำทางไปยังหน้า ProfilePage
            await Navigation.PushAsync(new ProfilePage());
        }
    }
}
