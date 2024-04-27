namespace EventManagementMVC.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string? EventName { get; set; }
        public DateTime Date { get; set; }
        public string? Place { get; set; }

    }
}
