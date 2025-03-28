namespace Mauiv2.page;

public partial class DeletePage : ContentPage
{
    // ตัวแปรสำหรับเก็บข้อมูลวิชาจาก Viewadd
    public List<string> CourseList { get; set; }
    public string SelectedCourse { get; set; }

    // คำสั่งสำหรับถอนวิชา
    public Command WithdrawCommand { get; }

    public DeletePage()
    {
        InitializeComponent();

        // กำหนดข้อมูลวิชา
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

        // กำหนดคำสั่งสำหรับถอนวิชา
        WithdrawCommand = new Command(OnWithdrawCourse);

        // กำหนด BindingContext เพื่อใช้ข้อมูลใน View
        BindingContext = this;
    }

    private void OnWithdrawCourse()
    {
        if (string.IsNullOrEmpty(SelectedCourse))
        {
            DisplayAlert("ข้อมูลไม่ครบ", "กรุณาเลือกวิชาที่ต้องการถอน", "ตกลง");
        }
        else
        {
            // ทำการถอนวิชาที่เลือก
            DisplayAlert("การถอนวิชา", $"{SelectedCourse} ถูกถอนออกจากการลงทะเบียนแล้ว", "ตกลง");

            // ที่นี่คุณสามารถทำการบันทึกการถอนวิชาลงในฐานข้อมูลหรือระบบของคุณ
        }
    }
}
