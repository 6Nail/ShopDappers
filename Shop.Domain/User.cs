﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
    public class User : Entity
    {
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        // TODO
        //public string Address { get; set; }
        //public string Email { get; set; }
        // покупки, комментарии, рейтинги и тд;
        //public string VerificationCode { get; set; }
    }
}
