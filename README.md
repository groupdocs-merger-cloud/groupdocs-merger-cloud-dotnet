# GroupDocs.Merger Cloud SDK for .NET
This repository contains GroupDocs.Merger Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Merger Cloud REST APIs in your .NET applications.

GroupDocs.Merger Cloud allows you to merge documents and manipulate document structure across wide range of supported document types - PDF, DOCX/DOC, PPTX/PPT, XLSX/XLS, VSDX/VSD, ODT, ODS, ODP, HTML, EPUB and many others. Merge several documents into one, split single document to multiple documents, reorder or replace document pages, change page orientation, manage document password and perform other manipulations with GroupDocs.Merger Cloud API.
## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/merger/available-sdks/).

## Dependencies
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Merger.Cloud.Sdk.Api;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var appSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
            var appKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            var api = new InfoApi(appSid, appKey);

            try
            {
                // Get supported file formats
                var response = api.GetSupportedFileFormats();

                foreach (var format in response.Formats)
                {
                    Debug.Print(format.ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Print("Something went wrong: " + e.Message);
            }
        }
    }
}
```

## Licensing
All GroupDocs.Merger Cloud SDKs are licensed under [MIT License](LICENSE).

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/merger/net) | [Docs](https://docs.groupdocs.cloud/merger/) | [Demos](https://products.groupdocs.app/merger/family) | [API Reference](https://apireference.groupdocs.cloud/merger/) | [Examples](https://github.com/groupdocs-merger-cloud/groupdocs-merger-cloud-dotnet-samples) | [Blog](https://blog.groupdocs.cloud/category/merger/) | [Free Support](https://forum.groupdocs.cloud/c/merger) | [Free Trial](https://purchase.groupdocs.cloud/trial)
