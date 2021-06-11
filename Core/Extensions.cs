using Stubble.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace RestApi.Test.Core
{
    public static class Extensions
    {
        public static StringContent ToJsonContent(this string requestBody)
        {
            return new StringContent(requestBody, Encoding.UTF8, "application/json");
        }

        public static string RenderTags(this string content, object data)
        {
            var stubble = new StubbleVisitorRenderer();
            var output = stubble.Render(content, data);
            return output;
        }

        public static string ReadAllText(string filePath)
        {
            var path = $"{Directory.GetCurrentDirectory()}{filePath}";

            if (!File.Exists(path))
            {
                throw new ArgumentException($"Could not find file at path: {path}");
            }

            // Load the file
            var fileData = File.ReadAllText(path);
            return fileData;
        }
    }
}
