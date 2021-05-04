using System;
using System.Collections.Generic;
using System.Text;
using UPB.PR4.Data.Models;

namespace UPB.PR4.Data
{
    public class DbContext : InDBContext
    {
        public List<Group> GroupTable { get; set; }

        public DbContext()
        {
            GroupTable = new List<Group>();
        }

        public List<Group> AddGroups(List<Group> group)
        {
            GroupTable.AddRange(group);
            return group;
        }

        public List<Group> UpdateGroup(List<Group> groupUpd)
        {
            Group foundGroup;
            foreach (Group groupUpdate in groupUpd)
            {
                foundGroup = GroupTable.Find(group => group.Id == groupUpdate.Id);
                foundGroup.Name = groupUpdate.Name;
                foundGroup.AvailableSlots = groupUpdate.AvailableSlots;
            }
            return groupUpd;
        }

        public List<Group> DeleteGroup(List<Group> groupDel)
        {
            GroupTable.RemoveAll(group => groupDel.Exists(g => g.Id == group.Id));
            return groupDel;
        }

        public List<Group> GetAllGroups()
        {
            return GroupTable;
        }
    }
}
