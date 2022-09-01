#Server v1
`openapi-generator generate -i ContractFirstApi/openapis/openapiV1.json -g aspnetcore -o ContractFirstApi/Services/v1 --additional-properties=buildTarget=library,packageName=Petstore.v1`
#Server v2
`openapi-generator generate -i ContractFirstApi/openapis/openapiV2.json -g aspnetcore -o ContractFirstApi/Services/v2 --additional-properties=buildTarget=library,packageName=Petstore.v2`
#Client v1
`openapi-generator generate -i ContractFirstApi/openapis/openapiV1.json -g csharp-netcore -o ContractFirstApi.Tests/Clients/v1 --additional-properties=packageName=PetstoreV1`
#Client v2
`openapi-generator generate -i ContractFirstApi/openapis/openapiV2.json -g csharp-netcore -o ContractFirstApi.Tests/Clients/v2 --additional-properties=packageName=PetstoreV2`