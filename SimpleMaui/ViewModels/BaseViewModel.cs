using CommunityToolkit.Mvvm.ComponentModel;
using SimpleMaui.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMaui.ViewModels;
public partial class BaseViewModel:ObservableObject
{
	//inject navigation service
	protected readonly INavigationService _navigationService;
	public BaseViewModel(INavigationService navigationService)
	{
		_navigationService = navigationService;
	}
}
