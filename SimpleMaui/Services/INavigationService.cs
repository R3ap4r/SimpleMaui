using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMaui.Services;
public interface INavigationService
{
	/// <summary>
	/// Interface for the navigation service
	/// </summary>
	/// <param name="route"></param>
	/// <param name="parameters"></param>
	/// <returns></returns>

	Task NavigateToAsync(string route, IDictionary<string,object> parameters =null);
}
