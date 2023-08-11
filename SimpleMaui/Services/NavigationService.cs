using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMaui.Services;
public class NavigationService: INavigationService
{
	/// <summary>
	/// Go to the page with the given route and parameters if present
	/// </summary>
	/// <param name="route">name of the page to navigate to</param>
	/// <param name="parameters">name of the object to pass with it</param>
	/// <returns>Either with or without an object specified by the user</returns>
	public Task NavigateToAsync(string route,IDictionary<string,object> parameters = null)
	{
		if(parameters is null)
		{
			return Shell.Current.GoToAsync(route);
		}
		else
		{
			return Shell.Current.GoToAsync(route,parameters);
		}
	}
}
