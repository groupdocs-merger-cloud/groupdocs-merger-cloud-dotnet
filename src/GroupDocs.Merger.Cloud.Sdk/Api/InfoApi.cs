// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="InfoApi.cs">
//  Copyright (c) Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Merger.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using GroupDocs.Merger.Cloud.Sdk.Client;
    using GroupDocs.Merger.Cloud.Sdk.Client.RequestHandlers;
    using GroupDocs.Merger.Cloud.Sdk.Model;
    using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Merger Cloud API.
    /// </summary>
    public class InfoApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public InfoApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public InfoApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Retrieve information about document pages: size, height, width etc. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetInfoRequest" /></param>
        /// <returns><see cref="InfoResult"/></returns>
        public InfoResult GetInfo(GetInfoRequest request)
        {
            // verify the required parameter 'fileInfo' is set
            if (request.fileInfo == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileInfo' when calling GetInfo");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/info";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.fileInfo); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (InfoResult)SerializationHelper.Deserialize(response, typeof(InfoResult));
            }

            return null;
        }

        /// <summary>
        /// List supported file formats 
        /// </summary>
        /// <returns><see cref="FormatsResult"/></returns>
        public FormatsResult GetSupportedFileFormats()
        {
            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/formats";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (FormatsResult)SerializationHelper.Deserialize(response, typeof(FormatsResult));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetInfoRequest.cs">
//  Copyright (c) Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Merger.Cloud.Sdk.Model.Requests 
{
    using GroupDocs.Merger.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.InfoApi.GetInfo" /> operation.
    /// </summary>  
    public class GetInfoRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetInfoRequest"/> class.
          /// </summary>        
          public GetInfoRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetInfoRequest"/> class.
          /// </summary>
          /// <param name="fileInfo">File Info</param>
          public GetInfoRequest(FileInfo fileInfo)             
          {
              this.fileInfo = fileInfo;
          }
          
          /// <summary>
          /// File Info
          /// </summary>  
          public FileInfo fileInfo { get; set; }
    }
}
