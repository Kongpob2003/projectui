using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Mauiv2.page
{
    public class RegistrationInfoViewModel : INotifyPropertyChanged
    {
        private List<Course>? _courses; // ทำให้เป็น nullable
        private List<Course>? _filteredCourses; // ทำให้เป็น nullable

        public List<Course> Courses
        {
            get => _courses ??= new List<Course>(); // กำหนดค่าเริ่มต้นหากเป็น null
            set
            {
                _courses = value;
                OnPropertyChanged();
            }
        }

        public List<Course> FilteredCourses
        {
            get => _filteredCourses ??= new List<Course>(); // กำหนดค่าเริ่มต้นหากเป็น null
            set
            {
                _filteredCourses = value;
                OnPropertyChanged();
            }
        }

        // วิธีโหลดข้อมูลสำหรับแต่ละเทอม
        public void LoadCourses(int term)
        {
            if (term == 1)
            {
                Courses = new List<Course>
                {
                    new Course { CourseName = "โครงสร้างข้อมูล 1204207", Grade = "A" },
                    new Course { CourseName = "คอมพิวเตอร์กราฟิก 1204305", Grade = "B" },
                    new Course { CourseName = "วิศวกรรมซอฟต์แวร์ 1204304", Grade = "B" },
                    new Course { CourseName = "ปัญญาประดิษฐ์ 1204308", Grade = "A" },
                    new Course { CourseName = "ทฤษฎีการคำนวณ 1204301", Grade = "B" }
                };
            }
            else if (term == 2)
            {
                Courses = new List<Course>
                {
                    new Course { CourseName = "การพัฒนาโปรแกรมประยุกต์แบบข้ามระบบปฏิบัติการบนโทรศัพท์เคลื่อนที่ 1204433", Grade = "A" },
                    new Course { CourseName = "การวิเคราะห์และออกแบบระบบ 1204301", Grade = "C" },
                    new Course { CourseName = "การวิเคราะห์และออกแบบขั้นตอนวิธี 1204302", Grade = "C+" },
                    new Course { CourseName = "การพัฒนาโปรแกรมประยุกต์บนอุปกรณ์พกพา 1204303", Grade = "B+" },
                    new Course { CourseName = "สัมมนาวิทยาการคอมพิวเตอร์ 1204304", Grade = "A" }
                };
            }
            else if (term == 3)
            {
                Courses = new List<Course>
                {
                    new Course { CourseName = "อินเทอร์เน็ตในทุกสรรพสิ่ง 1204408", Grade = "A" },
                    new Course { CourseName = "การโปรแกรมเครือข่ายคอมพิวเตอร์ 1204415", Grade = "A" }
                };
            }

            // กำหนด FilteredCourses ให้เป็น Courses ทันทีหลังจากโหลดข้อมูล
            FilteredCourses = new List<Course>(Courses);
        }

        // ฟังก์ชันสำหรับค้นหาวิชา
        public void SearchCourses(string searchQuery)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                FilteredCourses = new List<Course>(Courses);
            }
            else
            {
                FilteredCourses = Courses.Where(course => course.CourseName.Contains(searchQuery)).ToList();
            }
        }

        // ฟังก์ชันถอนวิชา
        public void WithdrawCourse(Course course)
        {
            if (course != null)
            {
                Courses.Remove(course);
                FilteredCourses.Remove(course); // ถอนวิชาออกจากรายการที่กรองแล้ว
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Course
    {
        public string CourseName { get; set; }
        public string Grade { get; set; }
    }
}

