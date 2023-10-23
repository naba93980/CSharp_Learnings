namespace RuntimePolymorphism
{
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw in shape");
        }

        public abstract void Food();
    }
}