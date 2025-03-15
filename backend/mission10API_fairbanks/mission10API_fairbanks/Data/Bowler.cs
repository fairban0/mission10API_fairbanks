using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mission10API_fairbanks.Data
{
    public class Bowler
    {
        [Key]
        public int BowlerID { get; set; }  // Primary Key, Not Nullable

        public string? BowlerLastName { get; set; }    // Nullable in DB
        public string? BowlerFirstName { get; set; }    // Nullable in DB
        public string? BowlerMiddleInit { get; set; }   // Nullable in DB
        public string? BowlerAddress { get; set; }      // Nullable in DB
        public string? BowlerCity { get; set; }         // Nullable in DB
        public string? BowlerState { get; set; }        // Nullable in DB
        public string? BowlerZip { get; set; }          // Nullable in DB
        public string? BowlerPhoneNumber { get; set; }  // Nullable in DB

        [ForeignKey("Team")]
        public int? TeamID { get; set; }  // Nullable in DB

        public Team? Team { get; set; }   // Nullable relationship
    }
}

