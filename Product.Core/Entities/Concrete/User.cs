﻿using Product.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Entities.Concrete
{
    public class User:EntityBase,IEntity
    {
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public int OperationClaimId { get; set; }

        public OperaitonClaim OperaitonClaim { get; set; }
    }
}
