// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="TestFiles.cs">
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

using System.Collections.Generic;

namespace GroupDocs.Merger.Cloud.Sdk.Test.Api.Internal
{
    public static class TestFiles
    {
        public static readonly TestFile OnePageDocx = new TestFile("one-page.docx", "words\\");
        public static readonly TestFile NotExist = new TestFile("NotExist.docx", "some-folder/");
        public static readonly TestFile PasswordProtectedDocx = new TestFile("password-protected.docx", "words\\")
        {
            Password = "password"
        };

        public static readonly TestFile FourPagesDocx = new TestFile("four-pages.docx", "words\\");

        public static readonly TestFile TenPagesPdf = new TestFile("ten-pages.pdf", "pdf\\");
        public static readonly TestFile OnePageProtectedPdf = new TestFile("one-page-password.pdf", "pdf\\")
        {
            Password = "password"
        };
        public static readonly TestFile FourSheetsXlsx = new TestFile("four-sheets.xlsx","cells\\");
        public static readonly TestFile FourSheetsProtectedXlsx = new TestFile("four-sheets-protected.xlsx", "cells\\")
        {
            Password = "password"
        };
        public static readonly TestFile Txt = new TestFile("document.txt", "txt\\");


        public static IEnumerable<TestFile> TestFilesList
        {
            get
            {
                yield return OnePageDocx;
                yield return PasswordProtectedDocx;
                yield return FourPagesDocx;
                yield return TenPagesPdf;
                yield return OnePageProtectedPdf;
                yield return FourSheetsXlsx;
                yield return FourSheetsProtectedXlsx;
                yield return Txt;
            }
        }
    }
}
