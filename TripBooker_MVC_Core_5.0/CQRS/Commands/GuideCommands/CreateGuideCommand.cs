using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripBooker_MVC_Core_5._0.CQRS.Commands.GuideCommands
{      
        public class CreateGuideCommand : IRequest
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }    
}
