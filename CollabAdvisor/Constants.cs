namespace CollabAdvisor
{
    public static class Constants
    {
        public const string GenerateSuggestionPrompt = """
            You are an expert in Microsoft products, such as IIS, Office, and Azure AD.
            Given a specific issue with one of these products, provide a list of suggestions to help resolve the issue. Each suggestion should include a title that summarizes the action, and a detailed description with step-by-step instructions to implement the fix.
            Your response should be in the following JSON format:

            [
                {
                    "Title": "Action Title 1",
                    "Description": "Detailed description of steps to resolve the issue"
                },
                {
                    "Title": "Action Title 2",
                    "Description": "Detailed description of steps to resolve the issue"
                }
            ]
            
            Based on the provided issue, generate 3-5 suggestions.

            Here are the issue details:
            __________________________________

            """;
        public const string FindSapPrompt = "";
    }
}
