using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSUI.Models;
internal class MembershipDisplayModel {
    public int Id { get; set; }
    public string MemberFirstName { get; set; }
    public int MemberId { get; set; }
    public string MemberLastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string PhoneNumber1 { get; set; }
    public string PhoneNumber2 { get; set; }
    public string MembershipTypeName { get; set; }
    public string TrainersName { get; set; }

}
