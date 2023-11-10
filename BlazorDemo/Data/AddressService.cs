namespace BlazorDemo.Data
{
    public class AddressService
    {
        private static readonly List<Address> addresses = new List<Address>()
        {
            new Address(){Id=1,  City="City 001", State="USA", Street="Street 001", Zip="Zip 001"},
        };

        public List<Address> GetData()
        {
            var data = new List<Address>();
            data.Add(new Address() { Id = 1, City = "City 001", State = "USA", Street = "Street 001", Zip = "Zip 001" });
            data.Add(new Address() { Id = 2, City = "City 002", State = "USA", Street = "Street 002", Zip = "Zip 002" });
            data.Add(new Address() { Id = 3, City = "City 003", State = "USA", Street = "Street 003", Zip = "Zip 003" });
            data.Add(new Address() { Id = 4, City = "City 004", State = "USA", Street = "Street 004", Zip = "Zip 004" });
            data.Add(new Address() { Id = 5, City = "City 005", State = "USA", Street = "Street 005", Zip = "Zip 005" });
            data.Add(new Address() { Id = 6, City = "City 006", State = "USA", Street = "Street 006", Zip = "Zip 006" });
            data.Add(new Address() { Id = 7, City = "City 007", State = "USA", Street = "Street 007", Zip = "Zip 007" });
            data.Add(new Address() { Id = 8, City = "City 008", State = "USA", Street = "Street 008", Zip = "Zip 008" });
            data.Add(new Address() { Id = 9, City = "City 009", State = "USA", Street = "Street 009", Zip = "Zip 009" });
            data.Add(new Address() { Id = 10, City = "City 010", State = "USA", Street = "Street 010", Zip = "Zip 010" });
            return data;
        }

        public Address Get(int id)
        {
            return GetData().Where(p => p.Id == id).SingleOrDefault();
        }
    }
}
