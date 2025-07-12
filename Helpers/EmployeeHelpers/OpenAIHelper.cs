using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_PROJECT.Helpers.EmployeeHelpers
{
    public class OpenAIResponse
    {
        public string DetectedIssues { get; set; }
        public string SuggestedServices { get; set; }
    }

    public static class OpenAIHelper
    {
        public static async Task<OpenAIResponse> GetCarDetailingSuggestionsAsync(string base64Image, string apiKey)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                var requestBody = new
                {
                    model = "gpt-4.1-mini",
                    messages = new object[]
                    {
                        new
                        {
                            role = "system",
                            content = "You are a car detailing expert AI. Your job is to analyze a car's exterior image and identify any visible issues (like scratches, dull paint, mud, etc). Then recommend only the most suitable services from this list:\n\n- Basic Wash\n- Hand Wash\n- Pressure Wash\n- Clay Bar Treatment\n- Paint Correction\n- Scratch & Swirl Removal\n- Polishing\n- Waxing\n- Sealant Application\n- Ceramic Coating\n- Glass Cleaning\n- Headlight Restoration\n- Engine Bay Cleaning\n- Tire & Wheel Cleaning\n- Tire Dressing & Shine\n\nRespond STRICTLY in this format:\n\nDetected Issues: <comma separated list>\nSuggested Services: <comma separated list>"
                        },
                        new
                        {
                            role = "user",
                            content = new object[]
                            {
                                new { type = "text", text = "Analyze this car image and return Detected Issues and Suggested Services." },
                                new { type = "image_url", image_url = new { url = $"data:image/jpeg;base64,{base64Image}" } }
                            }
                        }
                    },
                    temperature = 0.5,
                    max_tokens = 300
                };

                var json = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"OpenAI API error: {error}");
                    return null;
                }

                var responseString = await response.Content.ReadAsStringAsync();

                JsonDocument doc = JsonDocument.Parse(responseString);
                string message = null;
                try
                {
                    message = doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
                }
                finally
                {
                    doc.Dispose();
                }
                if (string.IsNullOrWhiteSpace(message))
                    return null;

                string detectedIssues = "";
                string suggestedServices = "";

                var lines = message.Split('\n');
                foreach (var line in lines)
                {
                    if (line.Trim().StartsWith("Detected Issues", StringComparison.OrdinalIgnoreCase))
                        detectedIssues = line.Substring(line.IndexOf(':') + 1).Trim();
                    else if (line.Trim().StartsWith("Suggested Services", StringComparison.OrdinalIgnoreCase))
                        suggestedServices = line.Substring(line.IndexOf(':') + 1).Trim();
                }

                return new OpenAIResponse
                {
                    DetectedIssues = detectedIssues,
                    SuggestedServices = suggestedServices
                };
            }
        }
    }
}
