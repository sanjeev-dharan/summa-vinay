using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IAgentDetails
    {
        void RegAgentDetails(AgentDetails agentDetails);
        List<AgentDetails> DisplayAgentDetails();
        void ModifyAgentDetails();
        void RemoveAgent(string name);
        DataTable GetPendingApprovalData();
        bool approveUsers(int id, string tableName, string type);
    }
}
