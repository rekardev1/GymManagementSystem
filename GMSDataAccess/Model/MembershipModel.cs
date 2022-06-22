using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSDataAccess.Model;
public class MembershipModel {
    public int Id { get; set; }
    public int MemberId { get; set; }
    public string MemberName { get; set; }
    public int PlanId { get; set; }
    public string PlanName { get; set; }
    public List<EmployeeModel> Trainers { get; set; } = new List<EmployeeModel>();
    public DateTime StartingDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public bool IsExpired { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; }
    public bool AutoRenew { get; set; }
    public DateTime LastRenewDate { get; set; } = new DateTime(2000, 1, 1);
}
