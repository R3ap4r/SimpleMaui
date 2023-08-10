using SimpleMaui.ViewModels;

namespace SimpleMaui.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;
	}
}