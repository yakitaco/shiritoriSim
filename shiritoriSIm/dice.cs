using System;

namespace shiritoriSim {
    class dice {
        Random rnd;

        dice() {
            rnd = new System.Random();

        }

        public int get() {
            return rnd.Next(1, 7);
        }
    }
}
