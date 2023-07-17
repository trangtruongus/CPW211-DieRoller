namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1 - 6)
    /// </summary>
    public class Die
    {
        private static Random _random;

        /// <summary>
        /// Creates the die and rolls it to start with
        /// a random number
        /// </summary>
        static Die()
        {
            _random = new Random();
        }

        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/>
        /// to the new number if the die is not currently held. 
        /// Returns the <see cref="FaceValue"/>c
        /// </summary>
        /// to the new number if the die is not currently held. 
        /// Returns the <see cref="FaceValue"/>
        public byte Roll()
        {
            // Generate random number
            if (!IsHeld)
            {
                // Generate random number
                Random random = new();
                byte newValue = (byte)_random.Next(1, 7);

                FaceValue = newValue;
            }
            return FaceValue;
        }
    }
}