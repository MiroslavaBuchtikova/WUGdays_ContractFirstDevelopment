/*
 * Swagger Petstore
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using PetstoreV1.Client;
using PetstoreV1.Model;

namespace PetstoreV1.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPetsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a pet
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void CreatePets(int operationIndex = 0);

        /// <summary>
        /// Create a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreatePetsWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// List all pets
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many items to return at one time (max 100) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Pet&gt;</returns>
        List<Pet> ListPets(int? limit = default(int?), int operationIndex = 0);

        /// <summary>
        /// List all pets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many items to return at one time (max 100) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Pet&gt;</returns>
        ApiResponse<List<Pet>> ListPetsWithHttpInfo(int? limit = default(int?), int operationIndex = 0);
        /// <summary>
        /// Info for a specific pet
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">The id of the pet to retrieve</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Pet</returns>
        Pet ShowPetById(string petId, int operationIndex = 0);

        /// <summary>
        /// Info for a specific pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">The id of the pet to retrieve</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Pet</returns>
        ApiResponse<Pet> ShowPetByIdWithHttpInfo(string petId, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPetsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreatePetsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreatePetsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List all pets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many items to return at one time (max 100) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Pet&gt;</returns>
        System.Threading.Tasks.Task<List<Pet>> ListPetsAsync(int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all pets
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many items to return at one time (max 100) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Pet&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Pet>>> ListPetsWithHttpInfoAsync(int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Info for a specific pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">The id of the pet to retrieve</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Pet</returns>
        System.Threading.Tasks.Task<Pet> ShowPetByIdAsync(string petId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Info for a specific pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">The id of the pet to retrieve</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Pet)</returns>
        System.Threading.Tasks.Task<ApiResponse<Pet>> ShowPetByIdWithHttpInfoAsync(string petId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPetsApi : IPetsApiSync, IPetsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PetsApi : IPetsApi
    {
        private PetstoreV1.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PetsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PetsApi(string basePath)
        {
            this.Configuration = PetstoreV1.Client.Configuration.MergeConfigurations(
                PetstoreV1.Client.GlobalConfiguration.Instance,
                new PetstoreV1.Client.Configuration { BasePath = basePath }
            );
            this.Client = new PetstoreV1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new PetstoreV1.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = PetstoreV1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PetsApi(PetstoreV1.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = PetstoreV1.Client.Configuration.MergeConfigurations(
                PetstoreV1.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new PetstoreV1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new PetstoreV1.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = PetstoreV1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PetsApi(PetstoreV1.Client.ISynchronousClient client, PetstoreV1.Client.IAsynchronousClient asyncClient, PetstoreV1.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = PetstoreV1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public PetstoreV1.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public PetstoreV1.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PetstoreV1.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PetstoreV1.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create a pet 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void CreatePets(int operationIndex = 0)
        {
            CreatePetsWithHttpInfo();
        }

        /// <summary>
        /// Create a pet 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public PetstoreV1.Client.ApiResponse<Object> CreatePetsWithHttpInfo(int operationIndex = 0)
        {
            PetstoreV1.Client.RequestOptions localVarRequestOptions = new PetstoreV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PetstoreV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PetstoreV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "PetsApi.CreatePets";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/pets", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePets", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a pet 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreatePetsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await CreatePetsWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create a pet 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<PetstoreV1.Client.ApiResponse<Object>> CreatePetsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            PetstoreV1.Client.RequestOptions localVarRequestOptions = new PetstoreV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PetstoreV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PetstoreV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "PetsApi.CreatePets";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/pets", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePets", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all pets 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many items to return at one time (max 100) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Pet&gt;</returns>
        public List<Pet> ListPets(int? limit = default(int?), int operationIndex = 0)
        {
            PetstoreV1.Client.ApiResponse<List<Pet>> localVarResponse = ListPetsWithHttpInfo(limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all pets 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many items to return at one time (max 100) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Pet&gt;</returns>
        public PetstoreV1.Client.ApiResponse<List<Pet>> ListPetsWithHttpInfo(int? limit = default(int?), int operationIndex = 0)
        {
            PetstoreV1.Client.RequestOptions localVarRequestOptions = new PetstoreV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PetstoreV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PetstoreV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(PetstoreV1.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            localVarRequestOptions.Operation = "PetsApi.ListPets";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Pet>>("/pets", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPets", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all pets 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many items to return at one time (max 100) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Pet&gt;</returns>
        public async System.Threading.Tasks.Task<List<Pet>> ListPetsAsync(int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            PetstoreV1.Client.ApiResponse<List<Pet>> localVarResponse = await ListPetsWithHttpInfoAsync(limit, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all pets 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit">How many items to return at one time (max 100) (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Pet&gt;)</returns>
        public async System.Threading.Tasks.Task<PetstoreV1.Client.ApiResponse<List<Pet>>> ListPetsWithHttpInfoAsync(int? limit = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            PetstoreV1.Client.RequestOptions localVarRequestOptions = new PetstoreV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PetstoreV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PetstoreV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(PetstoreV1.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            localVarRequestOptions.Operation = "PetsApi.ListPets";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Pet>>("/pets", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPets", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Info for a specific pet 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">The id of the pet to retrieve</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Pet</returns>
        public Pet ShowPetById(string petId, int operationIndex = 0)
        {
            PetstoreV1.Client.ApiResponse<Pet> localVarResponse = ShowPetByIdWithHttpInfo(petId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Info for a specific pet 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">The id of the pet to retrieve</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Pet</returns>
        public PetstoreV1.Client.ApiResponse<Pet> ShowPetByIdWithHttpInfo(string petId, int operationIndex = 0)
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
            {
                throw new PetstoreV1.Client.ApiException(400, "Missing required parameter 'petId' when calling PetsApi->ShowPetById");
            }

            PetstoreV1.Client.RequestOptions localVarRequestOptions = new PetstoreV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PetstoreV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PetstoreV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("petId", PetstoreV1.Client.ClientUtils.ParameterToString(petId)); // path parameter

            localVarRequestOptions.Operation = "PetsApi.ShowPetById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Pet>("/pets/{petId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShowPetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Info for a specific pet 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">The id of the pet to retrieve</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Pet</returns>
        public async System.Threading.Tasks.Task<Pet> ShowPetByIdAsync(string petId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            PetstoreV1.Client.ApiResponse<Pet> localVarResponse = await ShowPetByIdWithHttpInfoAsync(petId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Info for a specific pet 
        /// </summary>
        /// <exception cref="PetstoreV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">The id of the pet to retrieve</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Pet)</returns>
        public async System.Threading.Tasks.Task<PetstoreV1.Client.ApiResponse<Pet>> ShowPetByIdWithHttpInfoAsync(string petId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
            {
                throw new PetstoreV1.Client.ApiException(400, "Missing required parameter 'petId' when calling PetsApi->ShowPetById");
            }


            PetstoreV1.Client.RequestOptions localVarRequestOptions = new PetstoreV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PetstoreV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PetstoreV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("petId", PetstoreV1.Client.ClientUtils.ParameterToString(petId)); // path parameter

            localVarRequestOptions.Operation = "PetsApi.ShowPetById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Pet>("/pets/{petId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShowPetById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}