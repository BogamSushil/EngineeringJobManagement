using System;
using Microsoft.AspNet.Identity;
namespace Portal.Models
{
    public sealed class Roles : IRole<int>
    {
        public static readonly Roles Administrator = new Roles("Administrator");
        public static readonly Roles CallCenterAjent = new Roles("CallCenterAjent");
        public static readonly Roles Supervisor = new Roles("Supervisor");
        public static readonly Roles Engineer = new Roles("Engineer");

        private Roles(string value)
        {
            this.Value = value;
        }

        public string Value { get; private set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}