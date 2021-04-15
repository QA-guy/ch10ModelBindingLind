using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }

        [Required(ErrorMessage ="Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter a description.")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Please enter a point value.  Allowed numbers are 1,2,3,5,8")]
        [RegularExpression("1|2|3|5|8",ErrorMessage ="Only accepted values are 1,2,3,5 and 8")]
        public string PointValue { get; set; }

        [Required(ErrorMessage ="Please select a Sprint number")]
        public string SprintId { get; set; }
        public Sprint Sprint { get; set; }

        [Required(ErrorMessage ="Please select a status.")]

        public string StatusId { get; set; }
        public Status Status { get; set;}

        

    }
}
