using System.ComponentModel.DataAnnotations;

namespace mission10API_fairbanks.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        public string TeamName { get; set; }

        public ICollection<Bowler>? Bowlers { get; set; }
    }
}
