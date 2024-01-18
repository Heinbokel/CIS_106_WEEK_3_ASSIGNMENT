namespace CIS_106_WEEK_3_ASSIGNMENT.models {

    /// <summary>
    /// Model that defines a film.
    /// </summary>
    /// <author>Bob Heinbokel</author>
    class Film {
        
        public string Id {get; set;}
        public string Title {get; set;}
        public int DurationInMinutes {get; set;}
        public string Synopsis {get; set;}

        /// <summary>
        /// Complete constructor for the film class.
        /// </summary>
        /// <param name="Id">The unique ID of the film.</param>
        /// <param name="Title">The title of the film.</param>
        /// <param name="DurationInMinutes">The duration in minutes of the film.</param>
        /// <param name="Synopsis">The synopsis of the film.</param>
        public Film(string Id, string Title, int DurationInMinutes, string Synopsis) {
            this.Id = Id;
            this.Title = Title;
            this.DurationInMinutes = DurationInMinutes;
            this.Synopsis = Synopsis;
        }
    }

}