using System;
using System.Collections.Generic;
using System.Text;
using UPB.PR4.Logic.Models;

namespace UPB.PR4.Logic.Managers
{
    public class GroupManager
    {
        public List <Group> GetAllGroups()
        {
            return null;
        }

        public Group CreateGroup(string groupName)
        {
            return new Group()
            {
                Name = groupName
            };
        }

        public Group UpdateGroup(Group group)
        {
            group.Name = "updated";
            return group;
        }

        public Group DeleteGroup(Group group)
        {
            group.Name = "deleted";
            return group;
        }
    }
}
