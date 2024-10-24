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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Models
{
    /// <summary>
    /// InlineResponse2008 model
    /// </summary>
    [Preserve]
    [DataContract(Name = "inline_response_200_8")]
    internal class InlineResponse2008
    {
        /// <summary>
        /// Creates an instance of InlineResponse2008.
        /// </summary>
        /// <param name="quantity">quantity param</param>
        [Preserve]
        public InlineResponse2008(int quantity = default)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// Parameter quantity of InlineResponse2008
        /// </summary>
        [Preserve]
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity{ get; }
    
        /// <summary>
        /// Formats a InlineResponse2008 into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            serializedModel += "quantity," + Quantity.ToString();
            return serializedModel;
        }

        /// <summary>
        /// Returns a InlineResponse2008 as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            var quantityStringValue = Quantity.ToString();
            dictionary.Add("quantity", quantityStringValue);
            
            return dictionary;
        }
    }
}
