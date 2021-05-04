using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UPB.PR4.Logic.Managers;
using UPB.PR4.Logic.Models;

namespace Practica4.Controllers
{
    [ApiController]
    [Route("/api/group")]
    public class GroupController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly GroupManager _groupManager;
        public GroupController(IConfiguration config)
        {
            _config = config;
            _groupManager = new GroupManager();
        }

        [HttpGet]
        public List<Group> GetGroups()
        {
           return _groupManager.GetAllGroups();
        }

        [HttpPost]
        public Group CreateGroup([FromBody] string groupName)
        {
            return _groupManager.CreateGroup(groupName);
        }

        [HttpPut]
        public Group UpdateGroup([FromBody] Group group)
        {
            return _groupManager.UpdateGroup(group);
        }
        [HttpDelete]
        public Group DeleteGroup([FromBody] Group group)
        {
            return _groupManager.DeleteGroup(group);
        }
    }
}
