using System;
using System.Collections.Generic;
using System.Text;
using UPB.PR4.Logic.Models;

namespace UPB.PR4.Logic.Managers
{
    public interface InGroupManager
    {
        List<Group> GetAllGroups();
        Group CreateGroup(Group group);
        Group UpdateGroup(Group group);
        Group DeleteGroup(Group group);
    }
}
