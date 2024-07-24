// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SecurityApi.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    public class SecurityApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public SecurityApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public SecurityApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Add document password protection 
        /// </summary>
        /// <param name="request">Request. <see cref="AddPasswordRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult AddPassword(AddPasswordRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling AddPassword");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/password";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "PUT", 
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
        /// Checks whether document is password protected 
        /// </summary>
        /// <param name="request">Request. <see cref="CheckPasswordRequest" /></param>
        /// <returns><see cref="PasswordResult"/></returns>
        public PasswordResult CheckPassword(CheckPasswordRequest request)
        {
            // verify the required parameter 'filePath' is set
            if (request.filePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filePath' when calling CheckPassword");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/password";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filePath", request.filePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (PasswordResult)SerializationHelper.Deserialize(response, typeof(PasswordResult));
            }

            return null;
        }

        /// <summary>
        /// Remove document password protection 
        /// </summary>
        /// <param name="request">Request. <see cref="RemovePasswordRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult RemovePassword(RemovePasswordRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling RemovePassword");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/password";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
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
        /// Update document password 
        /// </summary>
        /// <param name="request">Request. <see cref="UpdatePasswordRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult UpdatePassword(UpdatePasswordRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling UpdatePassword");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/password";
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
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AddPasswordRequest.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.SecurityApi.AddPassword" /> operation.
    /// </summary>  
    public class AddPasswordRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="AddPasswordRequest"/> class.
          /// </summary>        
          public AddPasswordRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="AddPasswordRequest"/> class.
          /// </summary>
          /// <param name="options">Options to specify document name and new password</param>
          public AddPasswordRequest(Options options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Options to specify document name and new password
          /// </summary>  
          public Options options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="CheckPasswordRequest.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.SecurityApi.CheckPassword" /> operation.
    /// </summary>  
    public class CheckPasswordRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="CheckPasswordRequest"/> class.
          /// </summary>        
          public CheckPasswordRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="CheckPasswordRequest"/> class.
          /// </summary>
          /// <param name="filePath">File path</param>
          /// <param name="storageName">Storage name</param>
          /// <param name="versionId">Version Id</param>
          public CheckPasswordRequest(string filePath, string storageName = null, string versionId = null)             
          {
              this.filePath = filePath;
              this.storageName = storageName;
              this.versionId = versionId;
          }
          
          /// <summary>
          /// File path
          /// </summary>  
          public string filePath { get; set; }
          
          /// <summary>
          /// Storage name
          /// </summary>  
          public string storageName { get; set; }
          
          /// <summary>
          /// Version Id
          /// </summary>  
          public string versionId { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RemovePasswordRequest.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.SecurityApi.RemovePassword" /> operation.
    /// </summary>  
    public class RemovePasswordRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="RemovePasswordRequest"/> class.
          /// </summary>        
          public RemovePasswordRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="RemovePasswordRequest"/> class.
          /// </summary>
          /// <param name="options">Options to specify document name and current password</param>
          public RemovePasswordRequest(Options options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Options to specify document name and current password
          /// </summary>  
          public Options options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="UpdatePasswordRequest.cs">
//  Copyright (c) 2003-2024 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.SecurityApi.UpdatePassword" /> operation.
    /// </summary>  
    public class UpdatePasswordRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="UpdatePasswordRequest"/> class.
          /// </summary>        
          public UpdatePasswordRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="UpdatePasswordRequest"/> class.
          /// </summary>
          /// <param name="options">Options to specify document name, current and new password</param>
          public UpdatePasswordRequest(UpdatePasswordOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Options to specify document name, current and new password
          /// </summary>  
          public UpdatePasswordOptions options { get; set; }
    }
}
