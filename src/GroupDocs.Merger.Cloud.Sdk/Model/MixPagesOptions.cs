// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="MixPagesOptions.cs">
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
    /// Defines options for documents JoinPages method
    /// </summary>  
    public class MixPagesOptions 
    {                       
        /// <summary>
        /// Allows to join word documents without empty space between documents.
        /// </summary>
        /// <value>Allows to join word documents without empty space between documents.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WordJoinModeEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum Continuous for "Continuous"
            /// </summary>            
            Continuous            
        }

        /// <summary>
        /// Compliance mode for the Word Ooxml format
        /// </summary>
        /// <value>Compliance mode for the Word Ooxml format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WordJoinComplianceEnum
        { 
            /// <summary>
            /// Enum Ecma3762006 for "Ecma376_2006"
            /// </summary>            
            Ecma3762006,
            
            /// <summary>
            /// Enum Iso295002008Transitional for "Iso29500_2008_Transitional"
            /// </summary>            
            Iso295002008Transitional,
            
            /// <summary>
            /// Enum Iso295002008Strict for "Iso29500_2008_Strict"
            /// </summary>            
            Iso295002008Strict,
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>            
            Auto            
        }

        /// <summary>
        /// Possible modes for the image joining.
        /// </summary>
        /// <value>Possible modes for the image joining.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageJoinModeEnum
        { 
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>            
            Horizontal,
            
            /// <summary>
            /// Enum Vertical for "Vertical"
            /// </summary>            
            Vertical            
        }

        /// <summary>
        /// Allows to join word documents without empty space between documents.
        /// </summary>
        public WordJoinModeEnum? WordJoinMode { get; set; }

        /// <summary>
        /// Compliance mode for the Word Ooxml format
        /// </summary>
        public WordJoinComplianceEnum? WordJoinCompliance { get; set; }

        /// <summary>
        /// Possible modes for the image joining.
        /// </summary>
        public ImageJoinModeEnum? ImageJoinMode { get; set; }

        /// <summary>
        /// Source documents for JoinPages operation
        /// </summary>  
        public List<FileInfo> Files { get; set; }

        /// <summary>
        /// Page numbers for document indicies in Files collection.
        /// </summary>  
        public List<MixPagesItem> FilesPages { get; set; }

        /// <summary>
        /// The output path
        /// </summary>  
        public string OutputPath { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MixPagesOptions {\n");
          sb.Append("  Files: ").Append(this.Files).Append("\n");
          sb.Append("  FilesPages: ").Append(this.FilesPages).Append("\n");
          sb.Append("  OutputPath: ").Append(this.OutputPath).Append("\n");
          sb.Append("  WordJoinMode: ").Append(this.WordJoinMode).Append("\n");
          sb.Append("  WordJoinCompliance: ").Append(this.WordJoinCompliance).Append("\n");
          sb.Append("  ImageJoinMode: ").Append(this.ImageJoinMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
