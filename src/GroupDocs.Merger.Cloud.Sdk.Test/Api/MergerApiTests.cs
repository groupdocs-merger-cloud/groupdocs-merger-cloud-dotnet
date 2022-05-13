// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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

using System.Collections.Generic;
using System.IO;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using GroupDocs.Merger.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Merger.Cloud.Sdk.Test.Api
{    
    public class MergerApiTests : BaseApiTest
    {
        [Test]
        public void TestMove()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var options = new MoveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                PageNumber = 1,
                NewPageNumber = 2
            };
            var request = new MoveRequest(options);

            // Act & Assert
            var result = MergeApi.Move(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestMoveProtected()
        {
            // Arrange
            var testFile = TestFiles.PasswordProtectedDocx;
            var options = new MoveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                PageNumber = 1,
                NewPageNumber = 2
            };
            var request = new MoveRequest(options);

            // Act & Assert
            var result = MergeApi.Move(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestRemove()
        {
            // Arrange
            var testFile = TestFiles.FourSheetsXlsx;
            var options = new RemoveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 }
            };
            var request = new RemoveRequest(options);

            // Act & Assert
            var result = MergeApi.Remove(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestRemoveProtected()
        {
            // Arrange
            var testFile = TestFiles.FourSheetsProtectedXlsx;
            var options = new RemoveOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 }
            };
            var request = new RemoveRequest(options);

            // Act & Assert
            var result = MergeApi.Remove(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestRotate()
        {
            // Arrange
            var testFile = TestFiles.TenPagesPdf;
            var options = new RotateOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 },
                Mode = RotateOptions.ModeEnum.Rotate90
            };
            var request = new RotateRequest(options);

            // Act & Assert
            var result = MergeApi.Rotate(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestRotateProtected()
        {
            // Arrange
            var testFile = TestFiles.OnePageProtectedPdf;
            var options = new RotateOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 1 },
                Mode = RotateOptions.ModeEnum.Rotate90
            };
            var request = new RotateRequest(options);

            // Act & Assert
            var result = MergeApi.Rotate(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestSplitPages()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var options = new SplitOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 },
                Mode = SplitOptions.ModeEnum.Pages
            };
            var request = new SplitRequest(options);

            // Act & Assert
            var result = DocumentApi.Split(request);

            Assert.AreEqual(2, result.Documents.Count);
        }

        [Test]
        public void TestSplitPagesProtected()
        {
            // Arrange
            var testFile = TestFiles.PasswordProtectedDocx;
            var options = new SplitOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 },
                Mode = SplitOptions.ModeEnum.Pages
            };
            var request = new SplitRequest(options);

            // Act & Assert
            var result = DocumentApi.Split(request);

            Assert.AreEqual(2, result.Documents.Count);
        }

        [Test]
        public void TestSwap()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var options = new SwapOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                FirstPageNumber = 2,
                SecondPageNumber = 4
            };
            var request = new SwapRequest(options);

            // Act & Assert
            var result = MergeApi.Swap(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestSwapProtected()
        {
            // Arrange
            var testFile = TestFiles.PasswordProtectedDocx;
            var options = new SwapOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                FirstPageNumber = 2,
                SecondPageNumber = 4
            };
            var request = new SwapRequest(options);

            // Act & Assert
            var result = MergeApi.Swap(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestExtract()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var options = new ExtractOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 }
            };
            var request = new ExtractRequest(options);

            // Act & Assert
            var result = MergeApi.Extract(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestExtractProtected()
        {
            // Arrange
            var testFile = TestFiles.PasswordProtectedDocx;
            var options = new ExtractOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 }
            };
            var request = new ExtractRequest(options);

            // Act & Assert
            var result = MergeApi.Extract(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestOrientation()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var options = new OrientationOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 },
                Mode = OrientationOptions.ModeEnum.Landscape
            };
            var request = new OrientationRequest(options);

            // Act & Assert
            var result = MergeApi.Orientation(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestOrientationProtected()
        {
            // Arrange
            var testFile = TestFiles.PasswordProtectedDocx;
            var options = new OrientationOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 },
                Mode = OrientationOptions.ModeEnum.Landscape
            };
            var request = new OrientationRequest(options);

            // Act & Assert
            var result = MergeApi.Orientation(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestPreview()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var options = new PreviewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 },
                Width = 600,
                Height = 900,
                Format = PreviewOptions.FormatEnum.Png
            };
            var request = new PreviewRequest(options);

            // Act & Assert
            var result = DocumentApi.Preview(request);

            Assert.AreEqual(2, result.Documents.Count);
        }

        [Test]
        public void TestPreviewProtected()
        {
            // Arrange
            var testFile = TestFiles.PasswordProtectedDocx;
            var options = new PreviewOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                Pages = new List<int?> { 2, 4 },
                Width = 600,
                Height = 900,
                Format = PreviewOptions.FormatEnum.Png
            };
            var request = new PreviewRequest(options);

            // Act & Assert
            var result = DocumentApi.Preview(request);

            Assert.AreEqual(2, result.Documents.Count);
        }

        [Test]
        public void TestJoin()
        {
            // Arrange
            var item1 = new JoinItem
            {
                FileInfo = TestFiles.PasswordProtectedDocx.ToFileInfo()
            };
            var item2 = new JoinItem
            {
                FileInfo = TestFiles.FourPagesDocx.ToFileInfo()
            };

            var options = new JoinOptions
            {
                JoinItems = new List<JoinItem> { item1, item2 },
                OutputPath = Path.Combine(DefaultOutputPath, "joined.docx")
            };

            var request = new JoinRequest(options);

            // Act & Assert
            var result = DocumentApi.Join(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestJoinCrossFormat()
        {
            // Arrange
            var item1 = new JoinItem
            {
                FileInfo = TestFiles.OnePageProtectedPdf.ToFileInfo()
            };
            var item2 = new JoinItem
            {
                FileInfo = TestFiles.FourPagesDocx.ToFileInfo()
            };

            var options = new JoinOptions
            {
                JoinItems = new List<JoinItem> { item1, item2 },
                OutputPath = Path.Combine(DefaultOutputPath, "joined.pdf")
            };

            var request = new JoinRequest(options);

            // Act & Assert
            var result = DocumentApi.Join(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }


        [Test]
        public void TestImport()
        {
            // Arrange
            var options = new ImportOptions
            {
                FileInfo = TestFiles.OnePageProtectedPdf.ToFileInfo(),
                Attachments = new List<string> { TestFiles.Txt.FullName },
                OutputPath = Path.Combine(DefaultOutputPath, "with-attachment.pdf")
            };

            var request = new ImportRequest(options);

            // Act & Assert
            var result = DocumentApi.Import(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }
    }
}
