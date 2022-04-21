using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSDataAccess.Model;
public class MembershipModel {
    public int Id { get; set; }
    public MemberModel Member { get; set; }
    public MembershipTypeModel MembershipType { get; set; }
    public List<EmployeeModel>Trainers { get; set; }
    public DateTime StartingDate { get; set; }
    public DateTime ExpirationDate { get; set; }
}
