﻿using System.ComponentModel.DataAnnotations.Schema;

using System.Text.Json.Serialization;

namespace Appusion.Core.Common.Entities.User
{
    /// <summary>
    /// User
    /// </summary>
    [Table("User", Schema = "Diet")]
    public class UserEntity : EntityBase
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public string GsmNumber { get; set; }

        public string EmailAddress { get; set; }

        [JsonIgnore]
        public string HashedPassword { get; set; }

        [JsonIgnore]
        public bool EmailAddressConfirmed { get; set; } =false;
        
        public DateTime CreateDate { get; set; }
    }
}
