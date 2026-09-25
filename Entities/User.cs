using abdullah_portfolio.Entities.interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace abdullah_portfolio.Entities
{
    public class User : IUser
    {
        [Key]
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [NotNull]
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [NotNull]
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [NotNull]
        public string PhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [NotNull]
        public string LinkedinAccount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [AllowNull]
        public string WebsiteUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
