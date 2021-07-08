using Microsoft.AspNetCore.Identity;
using System;

namespace Core.Model
{
    public class User : IdentityUser, IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string PlakaNo { get; set; }

        // Telefon ve email bilgiisi Identity sınıfında var
    }
}