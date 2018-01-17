namespace Animals
{

    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public int Speed {get; set;} 

        public virtual int Walk()
        {
            return this.Speed;
        }
    }

}
