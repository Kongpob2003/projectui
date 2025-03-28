namespace Mauiv2.page;

public class Viewlogin : ContentPage
{
    // จำลองข้อมูลผู้ใช้งาน พร้อมรูปภาพและอีเมลที่แตกต่างกัน
    public static List<User> MockUsers = new List<User>
    {
        new User { Username = "testuser1", Password = "1", Email = "1", ImagePath = "d.png" },
        new User { Username = "admin", Password = "admin123", Email = "admin@example.com", ImagePath = "a.png" },
        new User { Username = "guest", Password = "guestpass", Email = "guest@example.com", ImagePath = "b.png" }
    };

    public Viewlogin()
    {
        // ตัวอย่างแสดงข้อมูลผู้ใช้คนแรก พร้อมแสดงรูปภาพและอีเมลเฉพาะของผู้ใช้คนนั้น
        var selectedUser = MockUsers[0]; // สามารถเปลี่ยนเพื่อแสดงผู้ใช้คนอื่น

        Content = new VerticalStackLayout
        {
            Children = {
                // ดึงรูปภาพที่ตรงกับผู้ใช้ที่เลือกไว้
                new Image
                {
                    Source = selectedUser.ImagePath,  // รูปภาพจาก Resources/Images
                    HeightRequest = 200,
                    WidthRequest = 200,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                },

                // แสดงชื่อผู้ใช้
                new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Text = $"Welcome {selectedUser.Username}!",
                    FontSize = 20,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Colors.Black
                },

                // แสดงอีเมลของผู้ใช้
                new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Text = $"Email: {selectedUser.Email}",
                    FontSize = 16,
                    TextColor = Colors.Gray
                }
            }
        };
    }
}

// คลาสจำลองข้อมูลผู้ใช้งาน พร้อมฟิลด์สำหรับอีเมล
public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }      // เพิ่มฟิลด์ Email
    public string ImagePath { get; set; }  // ชื่อไฟล์รูปภาพ เช่น user1.png
}
