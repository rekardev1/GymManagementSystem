using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSDataAccess.Model;
public class MemberModel {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string PhoneNumber1 { get; set; }
    public string PhoneNumber2 { get; set; }

    public string FullName {
        get { return $"{FirstName} {LastName}"; }
    }


}
