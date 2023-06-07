// Note: the Azure OpenAI client library for .NET is in preview.
// Install the .NET library via NuGet: dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.5 

using Azure;
using Azure.AI.OpenAI;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddUserSecrets<Program>()
    .Build();

string key = "Your_OPEN_API_Key";
var openAiEndPoint = new Uri("https://Your-azure-openai.openai.azure.com/");
var azureKeyCredential = new AzureKeyCredential(key);
var modelDeploymentName = "YourModelName";
var promptInputs = "Provide a summary of the text below that captures its main idea.\n\nAt Microsoft, we have been on a quest to advance AI beyond existing techniques, by taking a more holistic, human-centric approach to learning and understanding. As Chief Technology Officer of Azure AI Cognitive Services, I have been working with a team of amazing scientists and engineers to turn this quest into a reality. In my role, I enjoy a unique perspective in viewing the relationship among three attributes of human cognition: monolingual text (X), audio or visual sensory signals, (Y) and multilingual (Z). At the intersection of all three, there’s magic—what we call XYZ-code as illustrated in Figure 1—a joint representation to create more powerful AI that can speak, hear, see, and understand humans better. We believe XYZ-code will enable us to fulfill our long-term vision: cross-domain transfer learning, spanning modalities and languages. The goal is to have pre-trained models that can jointly learn representations to support a broad range of downstream AI tasks, much in the way humans do today. Over the past five years, we have achieved human performance on benchmarks in conversational speech recognition, machine translation, conversational question answering, machine reading comprehension, and image captioning. These five breakthroughs provided us with strong signals toward our more ambitious aspiration to produce a leap in AI capabilities, achieving multi-sensory and multilingual learning that is closer in line with how humans learn and understand. I believe the joint XYZ-code is a foundational component of this aspiration, if grounded with external knowledge sources in the downstream AI tasks.\n\nMicrosoft is taking a human-centric approach to advancing AI, aiming to create a joint representation (XYZ-code) that can speak, hear, see, and understand humans better. This representation is intended to enable cross-domain transfer learning, spanning modalities and languages, and over the past five years, Microsoft has achieved human performance on benchmarks in various AI tasks. The goal is to produce a leap in AI capabilities, closer to how humans learn and understand.";

OpenAIClient client = new(openAiEndPoint, azureKeyCredential);

// If streaming is selected
Response<StreamingCompletions> response = await client.GetCompletionsStreamingAsync(
    modelDeploymentName, GetCompletionsOptions(promptInputs));

using StreamingCompletions streamingCompletions = response.Value;

// If streaming is not selected
Response<Completions> completionsResponse = await client.GetCompletionsAsync(
    deploymentOrModelName: modelDeploymentName, GetCompletionsOptions(promptInputs));

Completions completions = completionsResponse.Value;
// WriteLine(completions);

int index = 0;
foreach (string? text in completions?.Choices?.Select(c => c.Text)?.ToArray()!)
{
    WriteLine($"{++index}. {text}");
}

index = 0;
var input = "At Microsoft, we have been on a quest to advance AI beyond existing techniques, by taking a more holistic, human-centric approach to learning and understanding. As Chief Technology Officer of Azure AI Cognitive Services, I have been working with a team of amazing scientists and engineers to turn this quest into a reality. In my role, I enjoy a unique perspective in viewing the relationship among three attributes of human cognition: monolingual text (X), audio or visual sensory signals, (Y) and multilingual (Z). At the intersection of all three, there’s magic—what we call XYZ-code as illustrated in Figure 1—a joint representation to create more powerful AI that can speak, hear, see, and understand humans better. We believe XYZ-code will enable us to fulfill our long-term vision: cross-domain transfer learning, spanning modalities and languages. The goal is to have pre-trained models that can jointly learn representations to support a broad range of downstream AI tasks, much in the way humans do today. Over the past five years, we have achieved human performance on benchmarks in conversational speech recognition, machine translation, conversational question answering, machine reading comprehension, and image captioning. These five breakthroughs provided us with strong signals toward our more ambitious aspiration to produce a leap in AI capabilities, achieving multi-sensory and multilingual learning that is closer in line with how humans learn and understand. I believe the joint XYZ-code is a foundational component of this aspiration, if grounded with external knowledge sources in the downstream AI tasks.\n\nMicrosoft is taking a human-centric approach to advancing AI, aiming to create a joint representation (XYZ-code) that can speak, hear, see, and understand humans better. This representation is intended to enable cross-domain transfer learning, spanning modalities and languages, and over the past five years, Microsoft has achieved human performance on benchmarks in various AI tasks. The goal is to produce a leap in AI capabilities, closer to how humans learn and understand.";
foreach (var text in await Summarize(input))
{
    WriteLine($"{++index}. {text}");
}
WriteLine("\n\nPress any key ...");
ReadKey();

async Task<string[]> Summarize(string text)
{
    var prompts = $"Provide a summary of the text below that captures its main idea.\n\n{text}";
    CompletionsOptions completionOptions = GetCompletionsOptions(prompts);

    OpenAIClient client = new(openAiEndPoint, azureKeyCredential);

    // If streaming is not selected
    Response<Completions> completionsResponse = await client.GetCompletionsAsync(deploymentOrModelName: modelDeploymentName, completionOptions);

    Completions completions = completionsResponse.Value;
    var choices = completions.Choices;

    return choices.Select(c => c.Text).ToArray();
}

static CompletionsOptions GetCompletionsOptions(string prompts)
{
    return new CompletionsOptions()
    {
        Prompts = { prompts },
        Temperature = (float)0.3,
        MaxTokens = 250,
        NucleusSamplingFactor = (float)1,
        FrequencyPenalty = (float)0,
        PresencePenalty = (float)0,
        GenerationSampleCount = 1,
        Echo = true
    };
}