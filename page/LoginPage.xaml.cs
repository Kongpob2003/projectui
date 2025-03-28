using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Mauiv2;
using Microsoft.Maui.Controls;

namespace MyApp
{
    public partial class LoginPage : ContentPage
    {
        private List<User> users;

        // เปลี่ยน constructor เป็น async
        public LoginPage()
        {
            InitializeComponent();
            LoadMockDataAsync().GetAwaiter().GetResult(); // รอให้โหลดเสร็จ
        }

        // เปลี่ยนชื่อฟังก์ชันและทำให้เป็น async Task
        private async Task LoadMockDataAsync()
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync("mock_users.json");
                using var reader = new StreamReader(stream);
                string json = await reader.ReadToEndAsync();
                users = JsonSerializer.Deserialize<List<User>>(json);
                if (users == null || users.Count == 0)
                {
                    await DisplayAlert("ข้อผิดพลาด", "ไม่พบข้อมูลผู้ใช้ใน JSON", "ตกลง");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ข้อผิดพลาด", $"ไม่สามารถโหลดข้อมูล: {ex.Message}", "ตกลง");
                users = new List<User>(); // กำหนดค่าเริ่มต้นให้ไม่เป็น null
            }
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text?.Trim();
            string password = PasswordEntry.Text?.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("ข้อผิดพลาด", "กรุณากรอกอีเมลและรหัสผ่าน", "ตกลง");
                return;
            }

            if (users == null || users.Count == 0)
            {
                await DisplayAlert("ข้อผิดพลาด", "ไม่มีข้อมูลผู้ใช้ โปรดตรวจสอบการโหลด JSON", "ตกลง");
                return;
            }

            var user = users.Find(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) 
                                    && u.Password.Equals(password, StringComparison.OrdinalIgnoreCase));
            if (user != null)
            {
                await DisplayAlert("สำเร็จ", "เข้าสู่ระบบสำเร็จ!", "ตกลง");
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("ข้อผิดพลาด", "อีเมลหรือรหัสผ่านไม่ถูกต้อง", "ตกลง");
            }
        }
    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}