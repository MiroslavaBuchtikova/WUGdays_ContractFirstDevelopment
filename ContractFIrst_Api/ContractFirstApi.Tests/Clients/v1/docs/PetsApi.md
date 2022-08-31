# PetstoreV1.Api.PetsApi

All URIs are relative to *http://petstore.swagger.io/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePets**](PetsApi.md#createpets) | **POST** /pets | Create a pet |
| [**ListPets**](PetsApi.md#listpets) | **GET** /pets | List all pets |
| [**ShowPetById**](PetsApi.md#showpetbyid) | **GET** /pets/{petId} | Info for a specific pet |

<a name="createpets"></a>
# **CreatePets**
> void CreatePets ()

Create a pet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PetstoreV1.Api;
using PetstoreV1.Client;
using PetstoreV1.Model;

namespace Example
{
    public class CreatePetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io/v1";
            var apiInstance = new PetsApi(config);

            try
            {
                // Create a pet
                apiInstance.CreatePets();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetsApi.CreatePets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a pet
    apiInstance.CreatePetsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetsApi.CreatePetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Null response |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpets"></a>
# **ListPets**
> List&lt;Pet&gt; ListPets (int? limit = null)

List all pets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PetstoreV1.Api;
using PetstoreV1.Client;
using PetstoreV1.Model;

namespace Example
{
    public class ListPetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io/v1";
            var apiInstance = new PetsApi(config);
            var limit = 56;  // int? | How many items to return at one time (max 100) (optional) 

            try
            {
                // List all pets
                List<Pet> result = apiInstance.ListPets(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetsApi.ListPets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all pets
    ApiResponse<List<Pet>> response = apiInstance.ListPetsWithHttpInfo(limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetsApi.ListPetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | How many items to return at one time (max 100) | [optional]  |

### Return type

[**List&lt;Pet&gt;**](Pet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A paged array of pets |  * x-next - A link to the next page of responses <br>  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="showpetbyid"></a>
# **ShowPetById**
> Pet ShowPetById (string petId)

Info for a specific pet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PetstoreV1.Api;
using PetstoreV1.Client;
using PetstoreV1.Model;

namespace Example
{
    public class ShowPetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io/v1";
            var apiInstance = new PetsApi(config);
            var petId = "petId_example";  // string | The id of the pet to retrieve

            try
            {
                // Info for a specific pet
                Pet result = apiInstance.ShowPetById(petId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetsApi.ShowPetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShowPetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Info for a specific pet
    ApiResponse<Pet> response = apiInstance.ShowPetByIdWithHttpInfo(petId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetsApi.ShowPetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petId** | **string** | The id of the pet to retrieve |  |

### Return type

[**Pet**](Pet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Expected response to a valid request |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

