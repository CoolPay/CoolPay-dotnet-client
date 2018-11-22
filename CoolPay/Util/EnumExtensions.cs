﻿using System;

namespace CoolPay.Util
{
	public static class EnumExtensions
	{
		public static string GetName<T>(this T theEnum)
		{
			return Enum.GetName (typeof(T), theEnum);
		}
	}
}

