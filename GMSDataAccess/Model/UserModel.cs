﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSDataAccess.Model;
public  class UserModel {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public string Address { get; set; }
    public string PhoneNumber1 { get; set; }
    public string PhoneNumber2 { get; set; }
    
}
