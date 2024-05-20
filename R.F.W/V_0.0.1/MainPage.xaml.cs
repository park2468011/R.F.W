namespace V_0._0._1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        int a = 1;
        private void btn_plus_Clicked(object sender, EventArgs e)
        {
            Note.Text = "Note"+a;
            a++;
            
        }
    }

}
