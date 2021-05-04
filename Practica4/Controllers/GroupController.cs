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
        private readonly InGroupManager _groupManager;
        public GroupController(IConfiguration config, InGroupManager groupManager)
        {
            _config = config;
            _groupManager = groupManager;
            Console.Out.WriteLine($"Project: {_config.GetSection("ProjectTitle").Value}");
        }

        [HttpGet]
        public List<Group> GetGroups()
        {
           return _groupManager.GetAllGroups();
        }

        [HttpPost]
        public Group CreateGroup([FromBody] Group group)
        {
            return _groupManager.CreateGroup(group);
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
