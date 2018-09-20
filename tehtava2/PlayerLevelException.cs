using System;

namespace tehtava2 {
    public class PlayerLevelException : Exception {
        public PlayerLevelException():base ("Not enough level") {
            
        }
    }
}