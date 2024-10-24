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
    /// A single build file within the Build Files List response
    /// </summary>
    [Preserve]
    [DataContract(Name = "multiplay.builds.buildFilesListItem")]
    internal class MultiplayBuildsBuildFilesListItem
    {
        /// <summary>
        /// A single build file within the Build Files List response
        /// </summary>
        /// <param name="path">Build file path in storage.</param>
        /// <param name="contentHash">The \&quot;contentHash\&quot; should be MD5sum hash value.</param>
        /// <param name="uploaded">File upload happening async after file entry is created for some providers. This flag tell the user if the file synchronisation has completed.</param>
        /// <param name="signedUrl">This signed URL allows a user upload and download the content for this path.</param>
        [Preserve]
        public MultiplayBuildsBuildFilesListItem(string path, string contentHash, bool uploaded = default, string signedUrl = default)
        {
            Path = path;
            ContentHash = contentHash;
            Uploaded = uploaded;
            SignedUrl = signedUrl;
        }

        /// <summary>
        /// Build file path in storage.
        /// </summary>
        [Preserve]
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path{ get; }
        
        /// <summary>
        /// The \&quot;contentHash\&quot; should be MD5sum hash value.
        /// </summary>
        [Preserve]
        [DataMember(Name = "contentHash", IsRequired = true, EmitDefaultValue = true)]
        public string ContentHash{ get; }
        
        /// <summary>
        /// File upload happening async after file entry is created for some providers. This flag tell the user if the file synchronisation has completed.
        /// </summary>
        [Preserve]
        [DataMember(Name = "uploaded", EmitDefaultValue = true)]
        public bool Uploaded{ get; }
        
        /// <summary>
        /// This signed URL allows a user upload and download the content for this path.
        /// </summary>
        [Preserve]
        [DataMember(Name = "signedUrl", EmitDefaultValue = false)]
        public string SignedUrl{ get; }
    
        /// <summary>
        /// Formats a MultiplayBuildsBuildFilesListItem into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Path != null)
            {
                serializedModel += "path," + Path + ",";
            }
            if (ContentHash != null)
            {
                serializedModel += "contentHash," + ContentHash + ",";
            }
            serializedModel += "uploaded," + Uploaded.ToString() + ",";
            if (SignedUrl != null)
            {
                serializedModel += "signedUrl," + SignedUrl;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a MultiplayBuildsBuildFilesListItem as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Path != null)
            {
                var pathStringValue = Path.ToString();
                dictionary.Add("path", pathStringValue);
            }
            
            if (ContentHash != null)
            {
                var contentHashStringValue = ContentHash.ToString();
                dictionary.Add("contentHash", contentHashStringValue);
            }
            
            var uploadedStringValue = Uploaded.ToString();
            dictionary.Add("uploaded", uploadedStringValue);
            
            if (SignedUrl != null)
            {
                var signedUrlStringValue = SignedUrl.ToString();
                dictionary.Add("signedUrl", signedUrlStringValue);
            }
            
            return dictionary;
        }
    }
}
