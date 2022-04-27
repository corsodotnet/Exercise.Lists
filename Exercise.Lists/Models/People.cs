namespace Exercise.Lists.Models
{
    internal class People
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public People(int id, string name, bool isActive)
        {
            this.ID = id;
            this.Name = name;
            this.IsActive = isActive;
        }
    }
}
