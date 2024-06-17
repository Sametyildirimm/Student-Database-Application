namespace _210201090_project
{
    public partial class App : Application
    {
        public static DBTrans DBTrans { get; private set; }

        public static DBTrans2 DBTrans2 { get; private set; }


        public App(DBTrans dBTrans, DBTrans2 dBTrans2)
        {
            InitializeComponent();

            MainPage = new AppShell();

            DBTrans = dBTrans;

            DBTrans2 = dBTrans2;
        }
    }
}
