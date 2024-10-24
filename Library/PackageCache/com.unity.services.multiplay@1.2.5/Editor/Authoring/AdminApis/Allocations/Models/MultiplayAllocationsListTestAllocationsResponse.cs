//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Allocations.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Allocations.Models
{
    /// <summary>
    /// Response to a request to list test allocations, including pagination.
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.allocations.ListTestAllocationsResponse")]
    internal class MultiplayAllocationsListTestAllocationsResponse
    {
        /// <summary>
        /// Response to a request to list test allocations, including pagination.
        /// </summary>
        /// <param name="pagination">pagination param</param>
        /// <param name="allocations">allocations param</param>
        [Preserve]
        public MultiplayAllocationsListTestAllocationsResponse(Pagination pagination, List<TestAllocation> allocations)
        {
            Pagination = pagination;
            Allocations = allocations;
        }

        /// <summary>
        /// Parameter pagination of MultiplayAllocationsListTestAllocationsResponse
        /// </summary>
        [Preserve]
        [DataMember(Name = "pagination", IsRequired = true, EmitDefaultValue = true)]
        public Pagination Pagination{ get; }
        
        /// <summary>
        /// Parameter allocations of MultiplayAllocationsListTestAllocationsResponse
        /// </summary>
        [Preserve]
        [DataMember(Name = "allocations", IsRequired = true, EmitDefaultValue = true)]
        public List<TestAllocation> Allocations{ get; }
    
        /// <summary>
        /// Formats a MultiplayAllocationsListTestAllocationsResponse into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Pagination != null)
            {
                serializedModel += "pagination," + Pagination.ToString() + ",";
            }
            if (Allocations != null)
            {
                serializedModel += "allocations," + Allocations.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayAllocationsListTestAllocationsResponse as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
