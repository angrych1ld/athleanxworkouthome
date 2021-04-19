using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AthleanXHomeWorkout
{
    public class Exercise
    {
        
        public static Dictionary<string, Exercise> AllExercises = new Dictionary<string, Exercise>
        {
            { "a11", new Exercise(("All", "a-gifs/a1.1-all.gif")) },
            { "a12", new Exercise(("All", "a-gifs/a1.2-all.gif")) },
            { "a13", new Exercise(("All", "a-gifs/a1.3-all.gif")) },

            { "a21", new Exercise(("Advanced", "a-gifs/a2.1-adv.gif"), ("Beginner", "a-gifs/a2.1-beg.gif")) },
            { "a22", new Exercise(("All", "a-gifs/a2.2-all.gif")) },
            { "a23", new Exercise(("Advanced", "a-gifs/a2.3-adv.gif"), ("Beginner", "a-gifs/a2.3-beg.gif")) },

            { "a31", new Exercise(("Advanced", "a-gifs/a3.1-adv.gif"), ("Beginner", "a-gifs/a3.1-beg.gif")) },
            { "a32", new Exercise(("All", "a-gifs/a3.2-all.gif")) },
            { "a33", new Exercise(("All", "a-gifs/a3.3-all.gif")) },

            { "a41", new Exercise(("Advanced", "a-gifs/a4.1-adv.gif"), ("Beginner", "a-gifs/a4.1-beg.gif")) },
            { "a42", new Exercise(("Advanced", "a-gifs/a4.2-adv.gif"), ("Beginner", "a-gifs/a4.2-beg.gif")) },
            { "a43", new Exercise(("All", "a-gifs/a4.3-all.gif")) },

            { "a51", new Exercise(("All", "a-gifs/a5.1-all.gif")) },
            { "a52", new Exercise(("All", "a-gifs/a5.2-all.gif")) },
            { "a53", new Exercise(("All", "a-gifs/a5.3-all.gif")) },

            { "a6", new Exercise(("All", "a-gifs/a6-all.gif")) },



            { "b11", new Exercise(("All", "b-gifs/b1.1-all.gif")) },
            { "b12", new Exercise(("All", "b-gifs/b1.2-all.gif")) },
            { "b13", new Exercise(("All", "b-gifs/b1.3-all.gif")) },

            { "b21", new Exercise(("Advanced", "b-gifs/b2.1-adv.gif"), ("Beginner", "b-gifs/b2.1-beg.gif")) },
            { "b22", new Exercise(("Advanced", "b-gifs/b2.2-adv.gif"), ("Beginner", "b-gifs/b2.2-beg.gif")) },
            { "b23", new Exercise(("All", "b-gifs/b2.3-all.gif")) },

            { "b31", new Exercise(("All", "b-gifs/b3.1-all.gif")) },
            { "b32", new Exercise(("All", "b-gifs/b3.2-all.gif")) },
            { "b33", new Exercise(("All", "b-gifs/b3.3-all.gif")) },

            { "b41", new Exercise(("Advanced", "b-gifs/b4.1-adv.gif"), ("Beginner", "b-gifs/b4.1-beg.gif")) },
            { "b42", new Exercise(("All", "b-gifs/b4.2-all.gif")) },
            { "b43", new Exercise(("All", "b-gifs/b4.3-all.gif")) },

            { "b51", new Exercise(("All", "b-gifs/b5.1-all.gif")) },
            { "b52", new Exercise(("All", "b-gifs/b5.2-all.gif")) },
            { "b53", new Exercise(("All", "b-gifs/b5.3-all.gif")) },

            { "b6", new Exercise(("All", "b-gifs/b6-all.gif")) }


        };

        public (string Title, string Address)[] Variations { get; set; }

        public Exercise(params (string, string)[] variations) {
            Variations = variations;
        }
    }
}
