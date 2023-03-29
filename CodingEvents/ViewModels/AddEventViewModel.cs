using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage= "Name of event is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Event name should be between 3 and 50 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Event description is required")]
        [StringLength(500, ErrorMessage = "Description is over 500 characters")]
        public string? Description { get; set; }

        [EmailAddress]
        public string? ContactEmail { get; set; }

        [Required(ErrorMessage = "Please enter the Location!")]
        [StringLength(140, MinimumLength = 25, ErrorMessage= "Please enter a valid Location")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Please estimate the number of attendees")]
        [Range(0, 100000, ErrorMessage = "Please enter a number between 0 - 100,000")]
        public int? NumOfAttendees { get; set; }
    }
}
