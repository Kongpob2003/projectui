namespace Mauiv2.page;

public class ViewDelete : ContentPage
{
    // ตัวแปรสำหรับเก็บข้อมูลวิชา
    public List<string> CourseList { get; set; }

    public ViewDelete()
    {
        // กำหนดค่าข้อมูลวิชาที่จะใช้
        CourseList = new List<string>
        {
            "โครงสร้างข้อมูล",
            "คอมพิวเตอร์กราฟิก",
            "วิศวกรรมซอฟต์แวร์",
            "ปัญญาประดิษฐ์",
            "ทฤษฎีการคำนวณ",
            "การพัฒนาโปรแกรมประยุกต์แบบข้ามระบบปฏิบัติการบนโทรศัพท์เคลื่อนที่",
            "การวิเคราะห์และออกแบบระบบ",
            "การวิเคราะห์และออกแบบขั้นตอนวิธี",
            "การพัฒนาโปรแกรมประยุกต์บนอุปกรณ์พกพา",
            "สัมมนาวิทยาการคอมพิวเตอร์",
            "อินเทอร์เน็ตในทุกสรรพสิ่ง",
            "การโปรแกรมเครือข่ายคอมพิวเตอร์"
        };

        // สร้าง UI สำหรับแสดงวิชาที่สามารถถอน
        Content = new VerticalStackLayout
        {
            Children = {
                new Label { 
                    HorizontalOptions = LayoutOptions.Center, 
                    VerticalOptions = LayoutOptions.Center, 
                    Text = "รายการวิชาที่ลงทะเบียน" 
                },
                new ListView
                {
                    ItemsSource = CourseList, // กำหนดให้แสดงข้อมูลจาก CourseList
                    SelectedItem = null // เมื่อเลือกแล้วจะไม่แสดงใน UI
                },
                new Button
                {
                    Text = "ถอนวิชา",
                    Command = new Command(OnWithdrawCourse) // กดปุ่มเพื่อถอนวิชา
                }
            }
        };
    }

    // ฟังก์ชันที่เรียกเมื่อกดปุ่มถอนวิชา
    private void OnWithdrawCourse()
    {
        var selectedCourse = "โครงสร้างข้อมูล"; // ตัวอย่าง: เลือกวิชา "โครงสร้างข้อมูล"
        
        // คุณสามารถเปลี่ยน selectedCourse ได้จาก UI เมื่อผู้ใช้เลือกวิชาจาก ListView หรือ Picker
        DisplayAlert("การถอนวิชา", $"{selectedCourse} ถูกถอนออกจากการลงทะเบียนแล้ว", "ตกลง");
        
        // ที่นี่คุณสามารถทำการถอนวิชาจากฐานข้อมูลหรือระบบของคุณ
    }
}
