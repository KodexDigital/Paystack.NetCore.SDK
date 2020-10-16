# Paystack.NetCore.SDK
A library for Paystack payment gateway for the .Net Core community.

### REQUIREMENT
This Library is for .Net Core users

### INSTALLATION
Install this library from [NuGet](https://www.nuget.org/packages/Paystack.NetCore.SDK/) 

## HOW IT WORKS

### NOTE: 
- For every Controller, should attribute with [System.Obsolete]) at the top.
- Make sure your SecreteKey is store in appsetting.json file
- EXAMPLE:
    **"PaystackService": {"SecretKey": "YOUR_SECRETKEY_HERE"}**


#### 1. Transactions
   ## Initialize Transaction.
   **using Paystack.NetCore.SDK.Transactions;**
   ### Sample procedure

 
 ```sh  
var transactionIni = new PaystackTransaction(configuration.GetSection("PaystackService").GetSection("SecretKey").Value);
var response = await transactionIni.InitializeTransaction("customer@test.com", 1000000);
if (response.Status)
{
	Response.Headers.Add("Access-Control-Allow-Origin", "*");
	Response.Headers.Add("Access-Control-Allow-Origin", "*");
	Response.Redirect(response.SubData.AuthorizationUrl);
}
else
{
    //Error handling
}
```
