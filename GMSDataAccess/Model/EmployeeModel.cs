using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSDataAccess.Model;
public class EmployeeModel {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int Salary { get; set; }
    public string JobType { get; set; }
    public string PhoneNumber1 { get; set; }
    public string PhoneNumber2 { get; set; }

    public string Display {
        get { return $"{Id}. {Name}"; }
    }
}
