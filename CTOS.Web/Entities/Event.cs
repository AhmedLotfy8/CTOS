

// Entities folder is the location where the base classes exist (The same structure as database tables)


using CTOS.Web.Entities;

namespace CTOS.Web.Entities {
    public class Event {

        public int Id { get; set; } // Database Id

        public string EventId { get; set; } // UI Id

        public string EventName { get; set; }

        public string Location { get; set; }

        public string Priority { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


    }
    #region Navigational properties and relationships

    //public int LocationId { get; set; } // fk
    //public Location location { get; set; } // navigation

    //    public class Location {

    //        public int Id { get; set; }

    //        public string address { get; set; }

    //    }

    #endregion

}



//var eve = new Event();

//eve.location.address

