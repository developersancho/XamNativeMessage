using Xamarin.Forms;

namespace XamNativeMessage
{
    public partial class XamNativeMessagePage : ContentPage
    {
        public XamNativeMessagePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<IMessage>().LongAlert("Hello");
        }
    }
}
