using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGardenGroupModel;

namespace TheGardenGroupDAL
{
    public class TicketDAO : Base
    {

        private static IMongoCollection<Ticket> collection;

        public TicketDAO()
        {
            collection = db.GetCollection<Ticket>("tickets");
        }

        //public List<Ticket> ReadAllTests()
        //{
        //    return collection.AsQueryable().ToList<Ticket>();
        //}
    }
}
