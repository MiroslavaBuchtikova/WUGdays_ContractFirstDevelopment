#RUN

`openapi-generator-cli generate -i ContractFirstApi/openapis/openapiV2.json -g csharp-netcore -o ContractFirstApi.Tests/Clients/v2 --additional-properties=packageName=PetstoreV2`