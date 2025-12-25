using CS_Demo2Vid.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CS_Demo2Vid.Services
{
    public class JsonDemoLoader
    {
        public DemoExportData LoadDemoData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file '{filePath}' could not be found.");
            }

            string jsonContent = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            DemoExportData? data = JsonSerializer.Deserialize<DemoExportData>(jsonContent, options);

            if (data == null)
            {
                throw new InvalidOperationException("The JSON file could not be parsed.");
            }

            return data;
        }
    }
}

