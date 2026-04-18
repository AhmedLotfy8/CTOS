

// Entities folder is the location where the base classes exist (The same structure as database tables)


namespace CTOS.Web.Entities {
    public class Event {

        public int Id { get; set; } // Database Id

        public string EventId { get; set; } // UI Id

        public string EventName { get; set; }

        public string Location { get; set; }

        public string Priority { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        #region Navigational properties and relationships
        // If there are relationships between 2 or more entities

        //Product Entity ex:
        /*     
            public int CompanyId { get; set; }
            public Company Company { get; set; }
        */
        #endregion

    }
}
