using SQLite;

namespace DebtBuddy.Forms.Models
{
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public double Balance { get; set; }
        
        public double InterestRate { get; set; }
    }
}
