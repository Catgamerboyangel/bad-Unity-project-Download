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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Servers.Models
{
    /// <summary>
    /// Time series int64 metrics for the given server.
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.servers.timeSeriesInt64")]
    internal class MultiplayServersTimeSeriesInt64
    {
        /// <summary>
        /// Time series int64 metrics for the given server.
        /// </summary>
        /// <param name="name">Name for the time series.</param>
        /// <param name="data">Data pairs of Unix timestamps (ms) and int64 values.</param>
        [Preserve]
        public MultiplayServersTimeSeriesInt64(string name, List<List<long>> data)
        {
            Name = name;
            Data = data;
        }

        /// <summary>
        /// Name for the time series.
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name{ get; }

        /// <summary>
        /// Data pairs of Unix timestamps (ms) and int64 values.
        /// </summary>
        [Preserve]
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public List<List<long>> Data{ get; }

        /// <summary>
        /// Formats a MultiplayServersTimeSeriesInt64 into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Name != null)
            {
                serializedModel += "name," + Name + ",";
            }
            if (Data != null)
            {
                serializedModel += "data," + Data.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayServersTimeSeriesInt64 as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }

            if (Data != null)
            {
                var dataStringValue = Data.ToString();
                dictionary.Add("data", dataStringValue);
            }

            return dictionary;
        }
    }
}
