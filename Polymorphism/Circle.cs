namespace RuntimePolymorphism
{
    public sealed class Circle : Shape
    {
      /*  public override void Draw()
        {
            Console.WriteLine("Draw in circle");
        }*/

        public sealed override void Food()
        {
            Console.WriteLine("Panner hoga 🤣");
        }
    }

}

// only overridden method can be sealed and they cant be overridden further
// sealed class cant be derived