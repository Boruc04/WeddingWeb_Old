﻿using NUnit.Framework;
using WeddingWeb.Domain.Email;

namespace WeddingWeb.Domain.Tests
{

	public class EmailTests
	{
		[Test]
		public void when_createing_valid_email_expect_success()
		{
			var validEmail = MainEmailTests.CreateValidMainEmail();
			var validGuestNumber = GuestNumberTests.CreateValidGuestNumber();
			var validGuestList = GuestTests.CreateValidGuestList();
			var validAdditionalInfo = new AdditionalInfo() { Value = "test" };
			var validNeedHotel = new NeedHotel { Value = true };
			var validNeedDrive = new NeedDrive { Value = true };

			Assert.DoesNotThrow(() => new Email.Email(validEmail, validGuestNumber, validGuestList, validAdditionalInfo,
				validNeedHotel, validNeedDrive));
		}
	}
}
