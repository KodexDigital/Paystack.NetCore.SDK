﻿using System.Net.Mime;

namespace Paystack.NetCore.SDK.Constants
{
	public static class BaseConstants
	{
		public const string PaystackBaseEndPoint = "https://api.paystack.co/";
		public const string PaystackInitializeTransactionEndPoint = "transaction/initialize";
		public const string PaystackTransactionVerificationEndPoint = "transaction/verify";
		/// <summary>
		/// Application - Json Content Type
		/// </summary>
		public const string ContentTypeHeaderJson = MediaTypeNames.Application.Json;
		/// <summary>
		/// HTTP Authorization Header
		/// </summary>
		public const string AuthorizationHeaderType = "Bearer";
	}
}
