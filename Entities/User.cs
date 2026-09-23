using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace abdullah_portfolio.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
