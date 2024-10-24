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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http;



namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Models
{
    /// <summary>
    /// CCD based build details.
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.builds.ccdDetails")]
    internal class MultiplayBuildsCcdDetails
    {
        /// <summary>
        /// CCD based build details.
        /// </summary>
        /// <param name="bucketID">The CCD bucket ID for a build within an environment. If not provided, a new bucket will be created.</param>
        /// <param name="releaseID">The CCD release ID for a build within an environment. If not provided, a new release will be created.</param>
        [Preserve]
        public MultiplayBuildsCcdDetails(System.Guid bucketID, System.Guid releaseID = default)
        {
            BucketID = bucketID;
            ReleaseID = releaseID;
        }

        /// <summary>
        /// The CCD bucket ID for a build within an environment. If not provided, a new bucket will be created.
        /// </summary>
        [Preserve]
        [DataMember(Name = "bucketID", IsRequired = true, EmitDefaultValue = true)]
        public System.Guid BucketID{ get; }
        
        /// <summary>
        /// The CCD release ID for a build within an environment. If not provided, a new release will be created.
        /// </summary>
        [Preserve]
        [DataMember(Name = "releaseID", EmitDefaultValue = false)]
        public System.Guid ReleaseID{ get; }
    
        /// <summary>
        /// Formats a MultiplayBuildsCcdDetails into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (BucketID != null)
            {
                serializedModel += "bucketID," + BucketID + ",";
            }
            if (ReleaseID != null)
            {
                serializedModel += "releaseID," + ReleaseID;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayBuildsCcdDetails as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (BucketID != null)
            {
                var bucketIDStringValue = BucketID.ToString();
                dictionary.Add("bucketID", bucketIDStringValue);
            }
            
            if (ReleaseID != null)
            {
                var releaseIDStringValue = ReleaseID.ToString();
                dictionary.Add("releaseID", releaseIDStringValue);
            }
            
            return dictionary;
        }
    }
}
