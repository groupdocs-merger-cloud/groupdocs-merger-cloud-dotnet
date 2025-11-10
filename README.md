# GroupDocs.Merger Cloud SDK for .NET

This repository contains GroupDocs.Merger Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Merger Cloud REST APIs in your .NET applications.

GroupDocs.Merger Cloud allows you to merge documents and manipulate document structure across wide range of supported document types - PDF, DOCX/DOC, PPTX/PPT, XLSX/XLS, VSDX/VSD, ODT, ODS, ODP, HTML, EPUB and many others. Merge several documents into one, split single document to multiple documents, reorder or replace document pages, change page orientation, manage document password and perform other manipulations with GroupDocs.Merger Cloud API.

## How to use the SDK

The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/display/mergercloud/Available+SDKs#AvailableSDKs-.NET).

## Getting Started

This example demonstrates merging different Word files seamlessly with a few lines of code:

```csharp
using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to join specific pages from several source documents.
    /// </summary>
    public class JoinPagesFromVariousDocuments
    {
		public static void Run()
		{
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
            var apiInstance = new DocumentApi(configuration);

			try
			{
                var item1 = new JoinItem
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "WordProcessing/sample-10-pages.docx"
                    },
                    Pages = new List<int?> {  3, 6, 8 }
                };

                var item2 = new JoinItem
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "WordProcessing/four-pages.docx"
                    },
                    StartPageNumber= 1,
                    EndPageNumber = 4,
                    RangeMode = JoinItem.RangeModeEnum.OddPages 
                };

                var options = new JoinOptions
                {
                    JoinItems = new List<JoinItem> { item1, item2 },
                    OutputPath = "Output/joined-pages.docx"
                };

                var request = new JoinRequest(options);
                var response = apiInstance.Join(request);

                Console.WriteLine("Output file path: " + response.Path);
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}
```

## Licensing

All GroupDocs.Merger Cloud SDKs are licensed under [MIT License](LICENSE).

## Resources

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/merger/net) | [Docs](https://docs.groupdocs.cloud/merger/) | [Demos](https://products.groupdocs.app/merger/family) | [API Reference](https://apireference.groupdocs.cloud/merger/) | [Examples](https://github.com/groupdocs-merger-cloud/groupdocs-merger-cloud-dotnet-samples) | [Blog](https://blog.groupdocs.cloud/category/merger/) | [Free Support](https://forum.groupdocs.cloud/c/merger) | [Free Trial](https://purchase.groupdocs.cloud/trial)
