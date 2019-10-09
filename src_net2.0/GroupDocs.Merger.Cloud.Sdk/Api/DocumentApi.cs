// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DocumentApi.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
    public class DocumentApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public DocumentApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public DocumentApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Join multiple documents into one document 
        /// </summary>
        /// <param name="request">Request. <see cref="JoinRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult Join(JoinRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Join");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/join";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (DocumentResult)SerializationHelper.Deserialize(response, typeof(DocumentResult));
            }

            return null;
        }

        /// <summary>
        /// Generate document pages preview 
        /// </summary>
        /// <param name="request">Request. <see cref="PreviewRequest" /></param>
        /// <returns><see cref="MultiDocumentResult"/></returns>
        public MultiDocumentResult Preview(PreviewRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Preview");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/preview";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (MultiDocumentResult)SerializationHelper.Deserialize(response, typeof(MultiDocumentResult));
            }

            return null;
        }

        /// <summary>
        /// Split single document to multiple documents 
        /// </summary>
        /// <param name="request">Request. <see cref="SplitRequest" /></param>
        /// <returns><see cref="MultiDocumentResult"/></returns>
        public MultiDocumentResult Split(SplitRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Split");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/split";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (MultiDocumentResult)SerializationHelper.Deserialize(response, typeof(MultiDocumentResult));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="JoinRequest.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.DocumentApi.Join" /> operation.
    /// </summary>  
    public class JoinRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="JoinRequest"/> class.
          /// </summary>        
          public JoinRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="JoinRequest"/> class.
          /// </summary>
          /// <param name="options">Join options</param>
          public JoinRequest(JoinOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Join options
          /// </summary>  
          public JoinOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PreviewRequest.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.DocumentApi.Preview" /> operation.
    /// </summary>  
    public class PreviewRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="PreviewRequest"/> class.
          /// </summary>        
          public PreviewRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="PreviewRequest"/> class.
          /// </summary>
          /// <param name="options">Preview options</param>
          public PreviewRequest(PreviewOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Preview options
          /// </summary>  
          public PreviewOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SplitRequest.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.DocumentApi.Split" /> operation.
    /// </summary>  
    public class SplitRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="SplitRequest"/> class.
          /// </summary>        
          public SplitRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="SplitRequest"/> class.
          /// </summary>
          /// <param name="options">PageSplitOptions or TextSplitOptions</param>
          public SplitRequest(Options options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// PageSplitOptions or TextSplitOptions
          /// </summary>  
          public Options options { get; set; }
    }
}
