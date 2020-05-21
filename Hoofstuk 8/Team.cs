using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8  
{
    public class Team
    {
        private List<Member> team = new List<Member>();

        public Team(Member member, Member member2, Member member3, Member member4)
        {
            team.Add(member);
            team.Add(member2);
            team.Add(member3);
            team.Add(member4);
        }
        public string PrintAllMembers()
        {
            var report = new StringBuilder();
            foreach (Member item in team)
            {
                report.AppendLine(item.Print());
            }
            return report.ToString();
        }
    }
}
