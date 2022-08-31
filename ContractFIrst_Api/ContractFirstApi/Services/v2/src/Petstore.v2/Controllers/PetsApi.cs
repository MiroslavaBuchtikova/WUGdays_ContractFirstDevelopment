/*
 * Swagger Petstore
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Petstore.v2.Attributes;
using Petstore.v2.Models;

namespace Petstore.v2.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class PetsApiController : ControllerBase
    { 
        /// <summary>
        /// Create a pet
        /// </summary>
        /// <param name="ownerId">Put information about owner id</param>
        /// <response code="201">Null response</response>
        /// <response code="0">unexpected error</response>
        [HttpPost]
        [Route("/v2/pets")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 0, type: typeof(Error))]
        public abstract IActionResult CreatePets([FromQuery (Name = "ownerId")][Required()]int ownerId);

        /// <summary>
        /// List all pets with owners
        /// </summary>
        /// <param name="displayOwnerInfo">Display info about owner?</param>
        /// <param name="limit">How many items to return at one time (max 100)</param>
        /// <response code="200">A paged array of pets</response>
        /// <response code="0">unexpected error</response>
        [HttpGet]
        [Route("/v2/pets")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<Pet>))]
        [ProducesResponseType(statusCode: 0, type: typeof(Error))]
        public abstract IActionResult ListPets([FromQuery (Name = "displayOwnerInfo")][Required()]bool displayOwnerInfo, [FromQuery (Name = "limit")]int? limit);

        /// <summary>
        /// Info for a specific pet
        /// </summary>
        /// <param name="petId">The id of the pet to retrieve</param>
        /// <response code="200">Expected response to a valid request</response>
        /// <response code="0">unexpected error</response>
        [HttpGet]
        [Route("/v2/pets/{petId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Pet))]
        [ProducesResponseType(statusCode: 0, type: typeof(Error))]
        public abstract IActionResult ShowPetById([FromRoute (Name = "petId")][Required]string petId);
    }
}
