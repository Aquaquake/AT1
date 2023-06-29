namespace FindCar
{
    internal class Car
    {
        internal string? Model; // Internal field to store the car's model
        internal string? Make; // Internal field to store the car's make
        internal int Year; // Internal field to store the car's year
        internal decimal Price; // Internal field to store the car's price
        internal string? BodyType; // Internal field to store the car's body type
        internal int Weight; // Internal field to store the car's weight
        internal int Horsepower; // Internal field to store the car's horsepower
        internal int Kilowatts; // Internal field to store the car's kilowatts

        public int Id { get; internal set; } // Public property to get or set the car's ID
    }
}
