using System;
using System.Collections.Generic;
using System.Text;

namespace UPB.PR4.Logic.Models
{
    public static class GroupMappers
    {
        public static List<Data.Models.Group> DTOToDAOMapper(List<Group> DTOGroups)
        {
            List<Data.Models.Group> DAOGroups = new List<Data.Models.Group>();

            foreach (Group group in DTOGroups)
            {
                DAOGroups.Add(new Data.Models.Group()
                {
                    Id = group.Id,
                    Name = group.Name,
                    AvailableSlots = group.AvailableSlots
                });
            }

            return DAOGroups;
        }

        public static List<Group> DAOToDTOMapper(List<Data.Models.Group> DAOGroups)
        {
            List<Group> DTOGroups = new List<Group>();

            foreach (Data.Models.Group group in DAOGroups)
            {
                DTOGroups.Add(new Group()
                {
                    Id = group.Id,
                    Name = group.Name,
                    AvailableSlots = group.AvailableSlots
                });
            }

            return DTOGroups;
        }
    }
}
