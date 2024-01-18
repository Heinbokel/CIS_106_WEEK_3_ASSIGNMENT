using CIS_106_WEEK_3_ASSIGNMENT.models;

namespace CIS_106_WEEK_3_ASSIGNMENT.repositories {

    class ActorRepository {
        private int IdGenerationIndex = 10;
        
        // Pretend this list came from a database.
        private readonly List<Actor> Actors = new List<Actor>{
            new Actor("A0", "Minn", "Fertins", "Just a human who loves to spend his time adventuring."),
            new Actor("A1", "Brash", "Candicoot", "Born in 1996, he has been eating mangoes ever since."),
            new Actor("A2", "Bob", "Spongington", "Lives in a coconut under the ocean."),
            new Actor("A3", "Homme", "Tanks", "A wonderful actor from the USA."),
            new Actor("A4", "Lawrence", "Shrader", "Likes to act in movies that are pretty good."),
            new Actor("A5", "Smith", "Billy", "This is the biography, lorem ipsum, etc."),
            new Actor("A6", "Dog", "The Jake", "Has 5 kids and plays the viola."),
            new Actor("A7", "Rubble", "Trouble", "A 16 pound pomeranian born in Michigan."),
            new Actor("A8", "Theo", "Bo-Beo", "A 25 pound cavapoo born in Michigan."),
            new Actor("A9", "Act", "Acterson", "The last actor who ever lived.")
        };


        public Actor? RetrieveActorById(string id) {
            return this.Actors.SingleOrDefault((actor) => actor.Id == id);
        }

        public List<Actor> RetrieveActors() {
            return this.Actors;
        }

        public string AddActor(Actor actor) {
            actor.Id = $"A{IdGenerationIndex}";
            IdGenerationIndex++;
            this.Actors.Add(actor);
            return actor.Id;
        }

        public bool UpdateActorById(Actor actor, string id) {
            int index = this.Actors.FindIndex((actor) => actor.Id == id);
            if (index != -1) {
                actor.Id = id;
                this.Actors[index] = actor;
                return true;
            }
            Console.WriteLine($"Actor with ID {id} was not found for updating.");
            return false;
        }

        public bool DeleteActorById(string id) {
            int index = this.Actors.FindIndex((actor) => actor.Id == id);
            if (index != -1) {
                this.Actors.RemoveAt(index);
                return true;
            }
            Console.WriteLine($"Actor with ID {id} was not found for deletion.");
            return false;
        }
    }

}