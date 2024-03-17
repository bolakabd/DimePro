namespace DimePro.Entity
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AppUser(int id, string name)
        {
            Id = id;
            Name = name;  
        }
    }
}
