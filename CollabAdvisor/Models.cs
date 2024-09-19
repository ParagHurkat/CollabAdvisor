using System.ComponentModel.DataAnnotations;

namespace CollabAdvisor
{
    public class CaseModel
    {
        [Required(ErrorMessage = "Case number is required")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Case number must be a 16 digit number")]
        public string? CaseNumber { get; set; }
    }

    public class DescriptionModel
    {
        [Required(ErrorMessage = "Provide detils regarding the assistance needed")]
        public string? AssistanceDetails { get; set; }
    }

    public class SuggestionModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Expanded { get; set; } = false;
    }
}
