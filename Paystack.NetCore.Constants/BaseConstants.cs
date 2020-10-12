﻿namespace Paystack.NetCore.Constants
{
	public static class BaseConstants
	{
		public const string PaystackBaseEndPoint = "https://api.paystack.co/";
		public const string PaystackInitializeTransactionEndPoint = "transaction/initialize";
		public const string PaystackTransactionVerificationEndPoint = "transaction/verify";
		/// <summary>
		/// Application - Json Content Type
		/// </summary>
		public const string ContentTypeHeaderJson = "application/json";
		/// <summary>
		/// HTTP Authorization Header
		/// </summary>
		public const string AuthorizationHeaderType = "Bearer";
	}
}
