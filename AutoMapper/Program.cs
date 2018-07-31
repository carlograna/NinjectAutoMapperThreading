using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PersonDTO, Person>()
                .ForMember(
                    p => p.Address,
                    opt => opt.MapFrom(pdto => new Address()
                    {
                        Street = pdto.Street,
                        City = pdto.City,
                        State = pdto.State,
                        ZipCode = pdto.ZipCode
                    })
                );
            });

            var personDTO = new PersonDTO()
            {
                FirstName = "Carlo",
                LastName = "Spader",
                Street = "Calle 13",
                City = "San Juan",
                State = "Puerto Rico",
                ZipCode = "68516"
            };

            IMapper mapper = config.CreateMapper();
            var person = mapper.Map<PersonDTO, Person>(personDTO);

            Console.WriteLine("Person: {0}", person);
            Console.ReadLine();
        }
    }


    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public override string ToString()
        {
            return Street + ", " + City + ", " + State + ", " + ZipCode;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return FirstName + ", " + LastName + ", " + Address;
        }
    }

    public class PersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
