//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using UnityEngine;
using UnityEngine.Scripting;

namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Fleets.Http
{
    /// <summary>
    /// JsonObjectConverter overrides behaviour from JsonConverter to allow
    /// encapsulation of raw object types and conversion between different
    /// types.
    /// </summary>
    [Preserve]
    internal class JsonObjectConverter : JsonConverter
    {
        ///<inheritdoc cref="JsonConverter"/>
        /// <summary>Convert a JsonObject to JToken.</summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JsonObject jobj = (JsonObject) value;

            if (jobj.obj == null)
            {
                writer.WriteNull();
                return;
            }

            JToken t = JToken.FromObject(jobj.obj);
            t.WriteTo(writer);
        }

        ///<inheritdoc cref="JsonConverter"/>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                if (reader.Value != null)
                {
                    return new JsonObject(reader.Value);
                }
                else
                {
                    try
                    {
                        var jsonObject = JObject.Load(reader);
                        return new JsonObject(jsonObject);
                    }
                    // If an exception is thrown, this may be an array. Try parsing as array
                    catch (JsonReaderException)
                    {
                        var jsonArray = JArray.Load(reader);
                        return new JsonObject(jsonArray);
                    }
                    // If another error is thrown, let it fall through.
                }
            }

            return new JsonObject(null);
        }

        ///<inheritdoc cref="JsonConverter"/>
        public override bool CanConvert(System.Type objectType)
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// JsonObjectCollectionConverter overrides behaviour from JsonConverter to allow
    /// encapsulation of collections of raw object types and conversion between different
    /// types.
    /// </summary>
    [Preserve]
    internal class JsonObjectCollectionConverter : JsonConverter
    {
        ///<inheritdoc cref="JsonConverter"/>
        /// <summary>Convert a JsonObject to JToken.</summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var jobjCollection = value;
            var type = value.GetType();

            if (type == typeof(Dictionary<string, IDeserializable>))
            {
                jobjCollection = (Dictionary<string, IDeserializable>) value;
            }
            else if (type == typeof(List<IDeserializable>))
            {
                jobjCollection = (List<IDeserializable>) value;
            }
            else if (type == typeof(List<List<IDeserializable>>))
            {
                jobjCollection = (List<List<IDeserializable>>) value;
            }

            if (jobjCollection == null)
            {
                writer.WriteNull();
                return;
            }

            JToken t = JToken.FromObject(jobjCollection);
            t.WriteTo(writer);
        }

        ///<inheritdoc cref="JsonConverter"/>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                var objects = (List<object>) reader.Value;
                var result = new List<JsonObject>();
                foreach (object o in objects)
                {
                    result.Add(new JsonObject(o));
                }

                return result;
            }

            return null;
        }

        ///<inheritdoc cref="JsonConverter"/>
        public override bool CanConvert(System.Type objectType)
        {
            throw new System.NotImplementedException();
        }
    }
}
