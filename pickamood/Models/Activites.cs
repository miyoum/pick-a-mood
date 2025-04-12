namespace pickamood.Models
{
    public class Activites
    {
        public string Activite { get; set; }
        public string Details { get; set; }

        public Activites(string activite, string details)
        {
            Activite = activite;
            Details = details;
        }
    }
}
