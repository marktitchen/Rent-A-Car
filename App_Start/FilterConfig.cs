﻿using System.Web;
using System.Web.Mvc;

namespace Rent_A_Car
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
