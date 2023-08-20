using SimpleMaui.ViewModels;

namespace SimpleMaui.Views;

public partial class LogInView : ContentPage
{
	public LogInView(LogInViewModel logInViewModel)
	{
		InitializeComponent();
		BindingContext = logInViewModel;
	}
}