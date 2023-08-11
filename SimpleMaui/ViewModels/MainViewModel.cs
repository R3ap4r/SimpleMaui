using SimpleMaui.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMaui.ViewModels;
public partial class MainViewModel: BaseViewModel
{
	public MainViewModel(INavigationService navigationService) : base(navigationService)
	{
	}
}
