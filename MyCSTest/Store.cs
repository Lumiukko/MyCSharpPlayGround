
namespace MyCSTest
{
    public class Store
    {

        public string Name { get; private set; }
        public string Chain { get; private set; }
        public string Address { get; private set; }
        public GeoLocation Location { get; private set; }

        public Store(string name)
        {
            Name = name;
        }

        public Store(string name, string chain, string address)
        {
            Name = name;
            Chain = chain;
            Address = address;
        }

        public Store(string name, string chain, string address, GeoLocation location)
        {
            Name = name;
            Chain = chain;
            Address = address;
            Location = location;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}){2}", Name, Chain, (!Address.Equals(string.Empty) ? ", " + Address : ""));
        }

    }
}
