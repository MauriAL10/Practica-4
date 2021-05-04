using System;
using System.Collections.Generic;
using System.Text;
using UPB.PR4.Data.Models;

namespace UPB.PR4.Data
{
    public interface InDBContext
    {
        List<Group> AddGroups(List<Group> group);
        List<Group> UpdateGroup(List<Group> groupUpd);
        List<Group> DeleteGroup(List<Group> groupDel);
        List<Group> GetAllGroups();
    }
}
