namespace _210201090_project
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            Stu_List_View.ItemsSource = App.DBTrans.GetStudents();
        }

        private void Button_Add_Clicked(object sender, EventArgs e)
        {
            App.DBTrans.Add(new _210201090_project.Student
            {
                Name = Stu_Name.Text,
                Department = Stu_Dept.Text
            });
        }

        private void Button_Show_Clicked(object sender, EventArgs e)
        {
            Stu_List_View.ItemsSource = App.DBTrans.GetStudents();
        }

        private async void Stu_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var student = e.Item as Student;

            var action = await DisplayActionSheet("Options", "Cancel", null, "Delete");

            if (action == "Delete")
            {
                App.DBTrans.Delete(student);

               
                Stu_List_View.ItemsSource = App.DBTrans.GetStudents();
            }
        ((ListView)sender).SelectedItem = null;
        }
    }

}
