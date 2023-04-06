using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventCategoryViewModel
    {

        [Required(ErrorMessage ="Please enter an event category")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Please enter an event category between 3 and 20 characters long")]
        public string? Name { get; set; }
    }
}
