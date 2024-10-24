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

//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Models
{
    /// <summary>
    /// MultiplayBuildType enum.
    /// </summary>
    /// <value>The upload type of the build:   * `FILE_UPLOAD` - The build is created using directly uploaded game files, backed by CCD as the storage driver.   * `CONTAINER` - The build is created using a container image containing game files.   * `S3` - The build is created using an external Amazon S3 Bucket containing game files. </value>
    
    [Preserve]
    [JsonConverter(typeof(StringEnumConverter))]
    internal enum MultiplayBuildType
    {
        /// <summary>
        /// Enum FILEUPLOAD for value: FILE_UPLOAD
        /// </summary>
        [EnumMember(Value = "FILE_UPLOAD")]
        FILEUPLOAD = 1,

        /// <summary>
        /// Enum CONTAINER for value: CONTAINER
        /// </summary>
        [EnumMember(Value = "CONTAINER")]
        CONTAINER = 2,

        /// <summary>
        /// Enum S3 for value: S3
        /// </summary>
        [EnumMember(Value = "S3")]
        S3 = 3

    }
}



