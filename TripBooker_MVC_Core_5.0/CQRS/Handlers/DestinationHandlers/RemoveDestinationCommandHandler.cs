using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripBooker_MVC_Core_5._0.CQRS.Commands.DestinationCommands;

namespace TripBooker_MVC_Core_5._0.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;
        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}