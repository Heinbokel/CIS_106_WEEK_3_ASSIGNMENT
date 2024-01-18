using CIS_106_WEEK_3_ASSIGNMENT.models;

namespace CIS_106_WEEK_3_ASSIGNMENT.repositories {

    class FilmRepository {
        private int IdGenerationIndex = 4;
        
        // Pretend this list came from a database.
        private readonly List<Film> Films = new List<Film>{
            new Film("F0", "Super Fun Film", 90, "This is a super fun film."),
            new Film("F1", "Super Long Film", 180, "This is a super long film."),
            new Film("F2", "Oh No!", 121, "Oh no things are going bad in this film."),
            new Film("F3", "The Film of Films", 92, "The film to be the film of all films.")
        };


        public Film? RetrieveFilmById(string id) {
            return this.Films.SingleOrDefault((actor) => actor.Id == id);
        }

        public List<Film> RetrieveFilms() {
            return this.Films;
        }

        public List<string> RetrieveFilmActorsByFilmId(string id) {
            List<string> actorIds = [];
            switch (id) {
                case "F0":
                    actorIds = ["A0", "A4", "A7"];
                    break;
                case "F1":
                    actorIds = ["A1", "A2", "A7"];
                    break;
                case "F2":
                    actorIds = ["A8", "A9"];
                    break;
                case "F3":
                    actorIds = ["A0", "A1", "A2", "A3", "A4", "A5"];
                    break;
            }
            return actorIds;
        }
    }

}