using Microsoft.Maui.Controls;

namespace Mauiv2.page;

public partial class RegisterPage : ContentPage
{
    // ตัวแปรสำหรับเก็บข้อมูลวิชาจาก Viewadd
    private Viewadd _viewAdd;

    public RegisterPage()
    {
        InitializeComponent();
        _viewAdd = new Viewadd(); // สร้าง instance ของ Viewadd
    }

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        // อ่านข้อมูลชื่อวิชาจาก Entry และเก็บลงในตัวแปร
        string courseName = CourseEntry.Text;

        // ตรวจสอบว่าไม่ได้กรอกข้อมูลหรือกรอกข้อมูลผิด
        if (string.IsNullOrEmpty(courseName))
        {
            // หากไม่ได้กรอกชื่อวิชา จะแสดงข้อความผิดพลาด
            DisplayAlert("ข้อมูลไม่ครบ", "กรุณากรอกชื่อวิชาก่อนลงทะเบียน", "ตกลง");
        }
        else if (!_viewAdd.CourseList.Contains(courseName))
        {
            // หากกรอกชื่อวิชาแล้วแต่ไม่อยู่ในรายชื่อวิชาที่กำหนด
            DisplayAlert("ข้อมูลไม่ถูกต้อง", "ชื่อวิชาที่กรอกไม่อยู่ในรายการวิชาที่มี", "ตกลง");
        }
        else
        {
            // หากข้อมูลถูกต้องและกรอกครบ
            DisplayAlert("การลงทะเบียนสำเร็จ", $"วิชา {courseName} ถูกลงทะเบียนแล้ว!", "ตกลง");

            // ทำการบันทึกข้อมูลวิชาในที่ที่ต้องการ เช่น ฐานข้อมูล
            SaveCourseData(courseName);
        }
    }

    // ฟังก์ชันเก็บข้อมูลวิชา (ตัวอย่างการบันทึกข้อมูล)
    private void SaveCourseData(string courseName)
    {
        // ตัวอย่างการเก็บข้อมูลวิชาในที่ต่างๆ เช่น ฐานข้อมูล
        Console.WriteLine($"ชื่อวิชา: {courseName} ถูกบันทึกแล้ว");
    }
}
