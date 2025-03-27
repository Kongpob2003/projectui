using Mauiv2.page;
using Microsoft.Maui.Controls;

namespace Mauiv2.page
{
    public partial class RegistrationInfoPage : ContentPage
    {
        private RegistrationInfoViewModel _viewModel;

        public RegistrationInfoPage()
        {
            InitializeComponent();
            _viewModel = new RegistrationInfoViewModel();
            BindingContext = _viewModel; // กำหนด BindingContext
        }

        // เมื่อคลิกปุ่มเทอม ให้โหลดข้อมูลวิชาและเกรดที่เกี่ยวข้อง
        private void HandleTermButtonClicked(object sender, EventArgs e)
{
    var button = (Button)sender;
    if (button.CommandParameter is string termString && int.TryParse(termString, out int term))
    {
        _viewModel.LoadCourses(term); // โหลดข้อมูลจาก ViewModel
    }
}

        

        
    }
}
