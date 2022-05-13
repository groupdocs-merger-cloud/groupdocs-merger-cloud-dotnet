// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="JoinItem.cs">
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
    /// Describes document for join operation
    /// </summary>  
    public class JoinItem 
    {                       
        /// <summary>
        /// Range mode. Ignored if Pages collection is not empty. Default value is AllPages.
        /// </summary>
        /// <value>Range mode. Ignored if Pages collection is not empty. Default value is AllPages.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RangeModeEnum
        { 
            /// <summary>
            /// Enum AllPages for "AllPages"
            /// </summary>            
            AllPages,
            
            /// <summary>
            /// Enum OddPages for "OddPages"
            /// </summary>            
            OddPages,
            
            /// <summary>
            /// Enum EvenPages for "EvenPages"
            /// </summary>            
            EvenPages            
        }

        /// <summary>
        /// Allows to join word documents without empty space between documents
        /// </summary>
        /// <value>Allows to join word documents without empty space between documents</value>
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
        /// Range mode. Ignored if Pages collection is not empty. Default value is AllPages.
        /// </summary>
        public RangeModeEnum? RangeMode { get; set; }

        /// <summary>
        /// Allows to join word documents without empty space between documents
        /// </summary>
        public WordJoinModeEnum? WordJoinMode { get; set; }

        /// <summary>
        /// File info
        /// </summary>  
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// List of page numbers to use in a Join operation. NOTE: page numbering starts from 1.
        /// </summary>  
        public List<int?> Pages { get; set; }

        /// <summary>
        /// Start page number. Ignored if Pages collection is not empty.
        /// </summary>  
        public int? StartPageNumber { get; set; }

        /// <summary>
        /// End page number. Ignored if Pages collection is not empty.
        /// </summary>  
        public int? EndPageNumber { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class JoinItem {\n");
          sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
          sb.Append("  Pages: ").Append(this.Pages).Append("\n");
          sb.Append("  StartPageNumber: ").Append(this.StartPageNumber).Append("\n");
          sb.Append("  EndPageNumber: ").Append(this.EndPageNumber).Append("\n");
          sb.Append("  RangeMode: ").Append(this.RangeMode).Append("\n");
          sb.Append("  WordJoinMode: ").Append(this.WordJoinMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
