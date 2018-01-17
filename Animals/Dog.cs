namespace Animals
{

    public class Dog
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public int Speed {get; set;} 

        public int Walk()
        {
            return this.Speed;
        }
    }
}
