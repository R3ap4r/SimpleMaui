using SimpleMaui.Views;

namespace SimpleMaui;

public partial class AppShell: Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("MainView", typeof(MainView));
	}
}
