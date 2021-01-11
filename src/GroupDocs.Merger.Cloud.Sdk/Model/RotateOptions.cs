// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RotateOptions.cs">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
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

namespace GroupDocs.Merger.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Rotate pages options
    /// </summary>  
    public class RotateOptions : PageOptions 
    {                       
        /// <summary>
        /// Get or sets desired page rotation - 90, 180 or 270 degrees.
        /// </summary>
        /// <value>Get or sets desired page rotation - 90, 180 or 270 degrees.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        { 
            /// <summary>
            /// Enum Rotate90 for "Rotate90"
            /// </summary>            
            Rotate90,
            
            /// <summary>
            /// Enum Rotate180 for "Rotate180"
            /// </summary>            
            Rotate180,
            
            /// <summary>
            /// Enum Rotate270 for "Rotate270"
            /// </summary>            
            Rotate270            
        }

        /// <summary>
        /// Get or sets desired page rotation - 90, 180 or 270 degrees.
        /// </summary>
        public ModeEnum? Mode { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RotateOptions {\n");
          sb.Append("  Mode: ").Append(this.Mode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
