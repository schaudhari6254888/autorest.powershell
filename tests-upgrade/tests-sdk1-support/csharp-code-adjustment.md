# Code adjustment for autorest.csharp generated SDK

Our goal is to leverage autorest.powershell to generate identical track 1 SDk as those generated by autorest.csharp track 1 SDK generator. But since there are gaps between modelerfour and modeler v1, there are still some minor differences between SDKs generated by autorest.powershell and autorest.csharp. To make all the test cases passed, we have to adjust SDK generated by autorest.csharp to make them identical as those generated by autorest.powershell. And below are those adjustments and why we make these adjustments.

## Remove validation for api-version

For a global parameter named *api-version* as below, in modelerfour, the schema of *api-version* will be modeled as a string constant with the validation minLength dropped. Considering it is just a validation, it is safe for us to drop the validation code for *api-version*.  

```
  "parameters": {
    "ApiVersionParameter": {
      "name": "api-version",
      "in": "query",
      "required": true,
      "type": "string",
      "description": "The API version to use for this operation.",
      "minLength": 1
    }
  }
```

Below is the validation code that is removed from provider-aks/csharp and provider-storage/csharp.

```dotnetcli
if (this.Client.ApiVersion != null)
{
    if (this.Client.ApiVersion.Length < 1)
    {
        throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MinLength, "Client.ApiVersion", 1);
    }
}
```