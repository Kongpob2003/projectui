namespace Mauiv2.page;

public class Viewadd : ContentPage
{
    // ตัวแปรสำหรับเก็บข้อมูลชื่อวิชา
    public List<string> CourseList { get; set; }

    public Viewadd()
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

        // สร้าง UI
        Content = new VerticalStackLayout
        {
            Children = {
                new Label { 
                    HorizontalOptions = LayoutOptions.Center, 
                    VerticalOptions = LayoutOptions.Center, 
                    Text = "Welcome to .NET MAUI!" 
                },
                new Label { 
                    HorizontalOptions = LayoutOptions.Center, 
                    VerticalOptions = LayoutOptions.Center, 
                    Text = "รายการวิชาที่สามารถลงทะเบียน" 
                },
                new ListView
                {
                    ItemsSource = CourseList // กำหนดให้แสดงข้อมูลจาก List
                }
            }
        };
    }
}
