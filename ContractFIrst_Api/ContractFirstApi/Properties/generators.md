# Petstore.v1 - ASP.NET Core 3.1 Server

## Server v1

`openapi-generator generate -i ContractFirstApi/Contracts/openapiV1.json -g aspnetcore -o ContractFirstApi/Servers/v1 --additional-properties=buildTarget=library,packageName=Petstore.v1`
## Server v2
`openapi-generator generate -i ContractFirstApi/Contracts/openapiV2.json -g aspnetcore -o ContractFirstApi/Servers/v2 --additional-properties=buildTarget=library,packageName=Petstore.v2`
## Client v1
`openapi-generator generate -i ContractFirstApi/Contracts/openapiV1.json -g csharp-netcore -o ContractFirstApi.Tests/Clients/v1 --additional-properties=packageName=PetstoreV1`
## Client v2
`openapi-generator generate -i ContractFirstApi/Contracts/openapiV2.json -g csharp-netcore -o ContractFirstApi.Tests/Clients/v2 --additional-properties=packageName=PetstoreV2`