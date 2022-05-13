// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PagesApi.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    public class PagesApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public PagesApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public PagesApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Make new document with some pages from source document 
        /// </summary>
        /// <param name="request">Request. <see cref="ExtractRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult Extract(ExtractRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Extract");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/pages/extract";
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
        /// Move page to a new position within document 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult Move(MoveRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Move");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/pages/move";
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
        /// Make new document and apply new orientation mode for specified pages 
        /// </summary>
        /// <param name="request">Request. <see cref="OrientationRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult Orientation(OrientationRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Orientation");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/pages/orientation";
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
        /// Remove pages from document 
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult Remove(RemoveRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Remove");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/pages/remove";
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
        /// Rotate pages in document 
        /// </summary>
        /// <param name="request">Request. <see cref="RotateRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult Rotate(RotateRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Rotate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/pages/rotate";
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
        /// Swap two pages within document 
        /// </summary>
        /// <param name="request">Request. <see cref="SwapRequest" /></param>
        /// <returns><see cref="DocumentResult"/></returns>
        public DocumentResult Swap(SwapRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Swap");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/merger/pages/swap";
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
// <copyright company="Aspose Pty Ltd" file="ExtractRequest.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.PagesApi.Extract" /> operation.
    /// </summary>  
    public class ExtractRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ExtractRequest"/> class.
          /// </summary>        
          public ExtractRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ExtractRequest"/> class.
          /// </summary>
          /// <param name="options">Extract options</param>
          public ExtractRequest(ExtractOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Extract options
          /// </summary>  
          public ExtractOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="MoveRequest.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.PagesApi.Move" /> operation.
    /// </summary>  
    public class MoveRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="MoveRequest"/> class.
          /// </summary>        
          public MoveRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="MoveRequest"/> class.
          /// </summary>
          /// <param name="options">Move options</param>
          public MoveRequest(MoveOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Move options
          /// </summary>  
          public MoveOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="OrientationRequest.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.PagesApi.Orientation" /> operation.
    /// </summary>  
    public class OrientationRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="OrientationRequest"/> class.
          /// </summary>        
          public OrientationRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="OrientationRequest"/> class.
          /// </summary>
          /// <param name="options">Orientation options</param>
          public OrientationRequest(OrientationOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Orientation options
          /// </summary>  
          public OrientationOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RemoveRequest.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.PagesApi.Remove" /> operation.
    /// </summary>  
    public class RemoveRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="RemoveRequest"/> class.
          /// </summary>        
          public RemoveRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="RemoveRequest"/> class.
          /// </summary>
          /// <param name="options">Remove options</param>
          public RemoveRequest(RemoveOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Remove options
          /// </summary>  
          public RemoveOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RotateRequest.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.PagesApi.Rotate" /> operation.
    /// </summary>  
    public class RotateRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="RotateRequest"/> class.
          /// </summary>        
          public RotateRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="RotateRequest"/> class.
          /// </summary>
          /// <param name="options">Rotate options</param>
          public RotateRequest(RotateOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Rotate options
          /// </summary>  
          public RotateOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="SwapRequest.cs">
//  Copyright (c) 2003-2022 Aspose Pty Ltd
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
    /// Request model for <see cref="GroupDocs.Merger.Cloud.Sdk.Api.PagesApi.Swap" /> operation.
    /// </summary>  
    public class SwapRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="SwapRequest"/> class.
          /// </summary>        
          public SwapRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="SwapRequest"/> class.
          /// </summary>
          /// <param name="options">Swap options</param>
          public SwapRequest(SwapOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Swap options
          /// </summary>  
          public SwapOptions options { get; set; }
    }
}
