using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marauders_Oasis.Common
{
	public static class EntityValidationConstants
	{
		public static class Category
		{
			public const int NameMinLength = 10;
			public const int NameMaxLength = 50;

			public const int DescriptionMinLength = 10;
			public const int DescriptionMaxLength = 1000;
		}

		public static class Contract
		{
			public const int TitleMinLength = 2;
			public const int TitleMaxLength = 50;

			public const int LocationMinLength = 30;
			public const int LocationMaxLength = 150;

			public const int DescriptionMinLength = 50;
			public const int DescriptionMaxLength = 1000;

			public const decimal MinPrice = 0;

			public enum ContractStatusValues
			{
				Active,
				Completed,
				Failed,
				Quited
			}
		}
		public static class Contractor
		{
			public const int UsernameMinLength = 2;
			public const int UsernameMaxLength = 50;

			public const int PhoneNumberMinLength = 7;
			public const int PhoneNumberMaxLength = 15;
		}
	}
}
