//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine.Networking;
using System.Threading.Tasks;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.BuildConfigs.Helpers;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.BuildConfigs.Scheduler;
using Task = System.Threading.Tasks.Task;

namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.BuildConfigs.Http
{
    /// <summary>
    /// HttpClient Class.
    /// </summary>
    internal class HttpClient : IHttpClient
    {

        /// <summary>Default Constructor.</summary>
        
        public HttpClient()
        {
        }

        /// <inheritdoc/>
        public async Task<HttpClientResponse> MakeRequestAsync(string method, string url, byte[] body,
            Dictionary<string, string> headers, int requestTimeout)
        {
            return await CreateWebRequestAsync(method.ToUpper(), url, body, headers, requestTimeout);
        }

        /// <inheritdoc/>
        public async Task<HttpClientResponse> MakeRequestAsync(string method, string url,
            List<IMultipartFormSection> body,
            Dictionary<string, string> headers, int requestTimeout, string boundary = null)
        {
            return await CreateWebRequestAsync(method.ToUpper(), url, body, headers, requestTimeout, boundary);
        }

        // Create and make an asynchronous UnityWebRequest
        private async Task<HttpClientResponse> CreateWebRequestAsync(string method, string url, byte[] body,
            IDictionary<string, string> headers, int requestTimeout)
        {
            return await CreateHttpClientResponse(method, url, body, headers, requestTimeout);
        }

        private async Task<HttpClientResponse> CreateHttpClientResponse(string method, string url, byte[] body, IDictionary<string, string> headers,
            int requestTimeout)
        {
            var result = await await Task.Factory.StartNew(async () =>
                {
                    using (var request = new UnityWebRequest(url, method))
                    {
                        foreach (var header in headers)
                        {
                            request.SetRequestHeader(header.Key, header.Value);
                        }

                        request.timeout = requestTimeout;
                        if (body != null && (method == UnityWebRequest.kHttpVerbPOST ||
                                             method == UnityWebRequest.kHttpVerbPUT ||
                                             method == "PATCH"))
                        {
                            request.uploadHandler = new UploadHandlerRaw(body);
                        }

                        request.downloadHandler = new DownloadHandlerBuffer();
                        return await SendWebRequest(request);
                    }
                }, CancellationToken.None, TaskCreationOptions.None,
                Scheduler.ThreadHelper.TaskScheduler);
            return result;
        }

        // Create and make an asynchronous UnityWebRequest for a multipart body
        private async Task<HttpClientResponse> CreateWebRequestAsync(string method, string url,
            List<IMultipartFormSection> body,
            IDictionary<string, string> headers, int requestTimeout, string boundary = null)
        {
            var result = await await Task.Factory.StartNew(async () =>
                {
                    byte[] boundaryBytes = string.IsNullOrEmpty(boundary)
                        ? UnityWebRequest.GenerateBoundary()
                        : Encoding.Default.GetBytes(boundary);
                    var request = new UnityWebRequest(url, method);

                    foreach (var header in headers)
                    {
                        request.SetRequestHeader(header.Key, header.Value);
                    }

                    request.timeout = requestTimeout;
                    request = SetupMultipartRequest(request, body, boundaryBytes);
                    request.downloadHandler = new DownloadHandlerBuffer();

                    return await SendWebRequest(request);
                }, CancellationToken.None, TaskCreationOptions.None,
                Scheduler.ThreadHelper.TaskScheduler);
            return result;
        }

        // Serialize the body of a multipart form request
        private static UnityWebRequest SetupMultipartRequest(UnityWebRequest request,
            List<IMultipartFormSection> multipartFormSections, byte[] boundary)
        {
            byte[] data = (byte[]) null;
            if (multipartFormSections != null && (uint) multipartFormSections.Count > 0U)
            {
                data = UnityWebRequest.SerializeFormSections(multipartFormSections, boundary);
            }

            UploadHandler uploadHandler = (UploadHandler) new UploadHandlerRaw(data);
            uploadHandler.contentType =
                "multipart/form-data; boundary=" + Encoding.UTF8.GetString(boundary, 0, boundary.Length);
            request.uploadHandler = uploadHandler;
            request.downloadHandler = (DownloadHandler) new DownloadHandlerBuffer();

            return request;
        }

        // Send a request
        private UnityWebRequestAsyncOperation SendWebRequest(UnityWebRequest request)
        {
            return request.SendWebRequest();
        }
    }
}
