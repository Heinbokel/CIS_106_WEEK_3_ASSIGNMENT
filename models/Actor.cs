namespace CIS_106_WEEK_3_ASSIGNMENT.models {

    /// <summary>
    /// Model that defines an actor.
    /// </summary>
    /// <author>Bob Heinbokel</author>
    class Actor {
        
        public string? Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Biography {get; set;}

        /// <summary>
        /// Constructor for the Actor class to create a new actor (ID isn't present, it is created upon database call).
        /// </summary>
        /// <param name="FirstName">The first name of the actor.</param>
        /// <param name="LastName">The last name of the actor.</param>
        /// <param name="Biography">The biography of the actor.</param>
        public Actor(string FirstName, string LastName, string Biography) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Biography = Biography;
        }

        /// <summary>
        /// Complete Constructor for the Actor class.
        /// </summary>
        /// <param name="Id">The unique ID of the actor.</param>
        /// <param name="FirstName">The first name of the actor.</param>
        /// <param name="LastName">The last name of the actor.</param>
        /// <param name="Biography">The biography of the actor.</param>
        public Actor(string Id, string FirstName, string LastName, string Biography) {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Biography = Biography;
        }
    }

}