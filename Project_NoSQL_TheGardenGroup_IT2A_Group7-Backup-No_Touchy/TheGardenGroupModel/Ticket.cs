using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TheGardenGroupModel
{
    public class Ticket
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("priority")]
        public string Priority { get; set; }

        [BsonElement("sumbmitDate")]
        public DateTime SubmitDate { get; set; }

        [BsonElement("resolutionDate")]
        public DateTime ResolutionDate { get; set; }

        [BsonElement("userID")]
        public int UserID { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        public Ticket(string description, string priority, DateTime submitDate, DateTime resolutionDate, int userID, string status)
        {
            Description = description;
            Priority = priority;
            SubmitDate = submitDate;
            ResolutionDate = resolutionDate;
            UserID = userID;
            Status = status;
        }
    }
}
