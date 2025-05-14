// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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

using System.IO;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using GroupDocs.Merger.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Merger.Cloud.Sdk.Test.Api
{    
    public class MergerPasswordApiTests : BaseApiTest
    {
        [Test]
        public void TestCheckPassword()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;

            var request = new CheckPasswordRequest(testFile.FullName);

            // Act & Assert
            var result = PasswordApi.CheckPassword(request);

            Assert.AreEqual(false, result.IsPasswordSet);
        }

        [Test]
        public void TestCheckPasswordProtected()
        {
            // Arrange
            var testFile = TestFiles.PasswordProtectedDocx;

            var request = new CheckPasswordRequest(testFile.FullName);

            // Act & Assert
            var result = PasswordApi.CheckPassword(request);

            Assert.AreEqual(true, result.IsPasswordSet);
        }

        [Test]
        public void TestRemovePassword()
        {
            // Arrange
            var testFile = TestFiles.PasswordProtectedDocx;
            var options = new Options
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName)
            };
            var request = new RemovePasswordRequest(options);

            // Act & Assert
            var result = PasswordApi.RemovePassword(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestAddPassword()
        {
            // Arrange
            var testFile = TestFiles.FourPagesDocx;
            var options = new Options
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName)
            };
            options.FileInfo.Password = "NewPassword";
            var request = new AddPasswordRequest(options);

            // Act & Assert
            var result = PasswordApi.AddPassword(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }

        [Test]
        public void TestUpdatePassword()
        {
            // Arrange
            var testFile = TestFiles.PasswordProtectedDocx;
            var options = new UpdatePasswordOptions
            {
                FileInfo = testFile.ToFileInfo(),
                OutputPath = Path.Combine(DefaultOutputPath, testFile.FileName),
                NewPassword = "NewPassword"
            };

            var request = new UpdatePasswordRequest(options);

            // Act & Assert
            var result = PasswordApi.UpdatePassword(request);

            Assert.AreEqual(options.OutputPath, result.Path);
        }
    }
}
