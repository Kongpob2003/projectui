namespace Mauiv2.page;

public class Viewlogin : ContentPage
{
    // จำลองข้อมูลผู้ใช้งาน พร้อมรูปภาพที่แตกต่างกัน
    public static List<User> MockUsers = new List<User>
    {
        new User { Username = "testuser1", Password = "password123", ImagePath = "user1.png" },
        new User { Username = "admin", Password = "admin123", ImagePath = "admin.png" },
        new User { Username = "guest", Password = "guestpass", ImagePath = "guest.png" }
    };

    public Viewlogin()
    {
        // ตัวอย่างแสดงข้อมูลผู้ใช้คนแรก พร้อมแสดงรูปภาพเฉพาะของผู้ใช้คนนั้น
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
                }
            }
        };
    }
}

// คลาสจำลองข้อมูลผู้ใช้งาน พร้อมฟิลด์สำหรับรูปภาพ
public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string ImagePath { get; set; }  // ชื่อไฟล์รูปภาพ เช่น user1.png
}
