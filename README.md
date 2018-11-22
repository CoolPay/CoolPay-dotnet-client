# coolpay-dotnet-client
`coolpay-dotnet-client` is a official client for [CoolPay API](https://api.coolpay.com/). The CoolPay API enables you to accept payments in a secure and reliable manner.  
This assembly currently support CoolPay `v10` api.

## Installation
via nuget  

## Usage

Before doing anything you should register yourself with CoolPay and get access credentials. 
If you haven't please [click](https://coolpay.com/) here to apply.

### The base class

This client provides a base class for calling the CoolPay API, the base class is called `CoolPayRestClient.  
The base class will set the correct headers and credentials for you to call the service.  
The base class will also validate the response.  
Furthermore a basic implementation of paging and sorting exists.  
  
This base class can be used to call the api.  
  
You can either create a class with the properties you need to get returned, see `merchantexample.cs` for examples of this.   
Or you can simply return a dictionary from the service, for example of this please see `pingexample.cs`.  
You can call the service async, please see `pingexample.cs` for an example of this.  

#### The unit tests

To run the tests you need to set the corresponding environment variables, please see qpconfig.cs for more info.  