namespace _210201090_project;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
        Course_List_View.ItemsSource = App.DBTrans2.GetCourses();
    }

    private async void Course_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var course = e.Item as _210201090_project.Course;

        var action = await DisplayActionSheet("Options", "Cancel", null, "Delete");

        if (action == "Delete" && course != null)
        {
            // Remove the course from the database
            App.DBTrans2.Delete(course);

            // Refresh the list view from the database
            Course_List_View.ItemsSource = App.DBTrans2.GetCourses();
        }

    ((ListView)sender).SelectedItem = null;
    }

    private void Button_Show2_Clicked(object sender, EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans2.GetCourses();
    }

    private void Button_Add2_Clicked(object sender, EventArgs e)
    {
        App.DBTrans2.Add23(new _210201090_project.Course
        {
            CourseCode = CRS_Code.Text,
            CourseName = CRS_Name.Text
        });
    }
}