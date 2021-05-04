using System;
using System.Collections.Generic;
using System.Text;
using UPB.PR4.Data;
using UPB.PR4.Logic.Models;

namespace UPB.PR4.Logic.Managers
{
    public class GroupManager : InGroupManager
    {
        private int _Id;
        private readonly InDBContext _dbContext;
        public GroupManager(InDBContext dbContext)
        {
            _Id = 0;
            _dbContext = dbContext;
        }
        public List <Group> GetAllGroups()
        {
            return GroupMappers.DAOToDTOMapper(_dbContext.GetAllGroups());
        }

        public Group CreateGroup(Group group)
        {
            if (GrupoNoValido(group))
            {
                throw new Exception();
            }

            group.Id = $"Group-{llenar(_Id)}";
            _Id++;

            List<Data.Models.Group> groupDAO = GroupMappers.DTOToDAOMapper(new List<Group> { group });
            _dbContext.AddGroups(groupDAO);

            return group;
        }

        public Group UpdateGroup(Group group)
        {
            if (GrupoNoValido(group))
            {
                throw new Exception();
            }

            List<Data.Models.Group> groupDAO = GroupMappers.DTOToDAOMapper(new List<Group>() { group });
            _dbContext.UpdateGroup(groupDAO);

            return group;
        }

        public Group DeleteGroup(Group group)
        {
            if (GrupoNoValido(group))
            {
                throw new Exception();
            }

            List<Data.Models.Group> groupDAO = GroupMappers.DTOToDAOMapper(new List<Group> { group });
            _dbContext.DeleteGroup(groupDAO);

            return group;
        }

        public string llenar(int idGroup)
        {
            if (idGroup < 10)
                return $"00{idGroup}";
            else if (idGroup < 100)
                return $"0{idGroup}";
            else
                return $"{idGroup}";
        }

        public bool GrupoNoValido(Group group)
        {
            return String.IsNullOrEmpty(group.Name) || group.Name.Length > 50 || group.AvailableSlots <= 0;
        }
    }
}
