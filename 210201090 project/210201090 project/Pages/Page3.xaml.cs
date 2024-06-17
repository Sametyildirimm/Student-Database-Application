using System.Collections.ObjectModel;

namespace _210201090_project;

public partial class Page3 : ContentPage
{
    private Student selectedStudent;
    private Course selectedCourse;
    private ObservableCollection<Enrollment> enrollments;


    public Page3()
	{
		InitializeComponent();
        Stu_List_View.ItemsSource = App.DBTrans.GetStudents();
        Course_List_View.ItemsSource = App.DBTrans2.GetCourses();
        enrollments = new ObservableCollection<Enrollment>();
        Enroll_List_View.ItemsSource = enrollments;
    }

    private async void Enroll_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var enroll = e.Item as _210201090_project.Enrollment;

        var action = await DisplayActionSheet("Options", "Cancel", null, "Delete");

        if (action == "Delete" && enroll != null)
        {
            enrollments.Remove(enroll);
            Stu_List_View.ItemsSource = App.DBTrans.GetStudents();
            Course_List_View.ItemsSource = App.DBTrans2.GetCourses();
        }
     ((ListView)sender).SelectedItem = null;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (selectedStudent != null && selectedCourse != null)
        {
            enrollments.Add(new Enrollment
            {
                Name = selectedStudent.Name,
                Department = selectedStudent.Department,
                CourseName = selectedCourse.CourseName,
                CourseCode = selectedCourse.CourseCode
            });


            selectedStudent = null;
            selectedCourse = null;
            Stu_List_View.SelectedItem = null;
            Course_List_View.SelectedItem = null;
        }
        else
        {
            DisplayAlert("Error", "Please select both ", "OKEY");
        }

        Enroll_List_View.ItemsSource = enrollments;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Stu_List_View.ItemsSource = App.DBTrans.GetStudents();
        Course_List_View.ItemsSource = App.DBTrans2.GetCourses();
    }

    private void Stu_List_View_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        selectedStudent = e.SelectedItem as Student;
    }

    private void Course_List_View_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        selectedCourse = e.SelectedItem as Course;
    }
}