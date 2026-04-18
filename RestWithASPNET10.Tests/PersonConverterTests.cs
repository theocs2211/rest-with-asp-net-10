using FluentAssertions;
using RestWithASPNET10.Data.Converter.Impl;
using RestWithASPNET10.Data.DTO.V2;
using RestWithASPNET10.Models;

namespace RestWithASPNET10.Tests
{
    public class PersonConverterTests
    {
        private readonly PersonConverter _converter;
        public PersonConverterTests()
        {
            _converter = new PersonConverter();
        }

        [Fact]
        public void Parse_ShouldConvertPersonDTOToPerson()
        {
            // Arrange
            var personDTO = new PersonDTO
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main",
                Gender = "Male",
                BirthDay = new DateTime(1990, 1, 1),
            };
            var ExpectedPerson = new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main",
                Gender = "Male",
            };

            // Act
            var person = _converter.Parse(personDTO);

            // Assert
            person.Should().NotBeNull();
            person.Id.Should().Be(ExpectedPerson.Id);
            person.FirstName.Should().Be(ExpectedPerson.FirstName);
            person.LastName.Should().Be(ExpectedPerson.LastName);
            person.Address.Should().Be(ExpectedPerson.Address);
            person.Gender.Should().Be(ExpectedPerson.Gender);
        }
        [Fact]
        public void Parse_NullPersonDTO_ShouldReturnNull()
        {
            // Arrange
            PersonDTO personDTO = null;

            // Act
            Person person = _converter.Parse(personDTO);

            // Assert
            person.Should().BeNull();
        }

        [Fact]
        public void Parse_ShouldConvertPersonToPersonDTO()
        {
            // Arrange
            var person = new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main",
                Gender = "Male",
            };
            var ExpectedPersonDTO = new PersonDTO
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main",
                Gender = "Male",
            };

            // Act
            var personDTO = _converter.Parse(person);

            // Assert
            personDTO.Should().NotBeNull();
            personDTO.Id.Should().Be(ExpectedPersonDTO.Id);
            personDTO.FirstName.Should().Be(ExpectedPersonDTO.FirstName);
            personDTO.LastName.Should().Be(ExpectedPersonDTO.LastName);
            personDTO.Address.Should().Be(ExpectedPersonDTO.Address);
            personDTO.Gender.Should().Be(ExpectedPersonDTO.Gender);
        }
        [Fact]
        public void Parse_NullPerson_ShouldReturnNull()
        {
            // Arrange
            Person person = null;

            // Act
            PersonDTO personDTO = _converter.Parse(person);

            // Assert
            person.Should().BeNull();
        }

        [Fact]
        public void ParseList_ShouldConvertPersonDTOListToPersonList()
        {
            // Arrange
            var personDTOList = new List<PersonDTO>
            {
                new PersonDTO
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "123 Main",
                    Gender = "Male",
                },
                new PersonDTO
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Address = "456 Elm",
                    Gender = "Female",
                },
            };

            var ExpectedPersonList = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "123 Main",
                    Gender = "Male",
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Address = "456 Elm",
                    Gender = "Female",
                },
            };

            // Act
            var personList = _converter.ParseList(personDTOList);

            // Assert
            personList.Should().NotBeNull();
            personList.Count.Should().Be(ExpectedPersonList.Count);

            personList[0].Should().NotBeNull();
            personList[0].Id.Should().Be(ExpectedPersonList[0].Id);
            personList[0].FirstName.Should().Be(ExpectedPersonList[0].FirstName);
            personList[0].LastName.Should().Be(ExpectedPersonList[0].LastName);
            personList[0].Address.Should().Be(ExpectedPersonList[0].Address);
            personList[0].Gender.Should().Be(ExpectedPersonList[0].Gender);

            personList[1].Should().NotBeNull();
            personList[1].Id.Should().Be(ExpectedPersonList[1].Id);
            personList[1].FirstName.Should().Be(ExpectedPersonList[1].FirstName);
            personList[1].LastName.Should().Be(ExpectedPersonList[1].LastName);
            personList[1].Address.Should().Be(ExpectedPersonList[1].Address);
            personList[1].Gender.Should().Be(ExpectedPersonList[1].Gender);
        }
        [Fact]
        public void Parse_NullListPersonDTO_ShouldReturnNull()
        {
            // Arrange
            List<PersonDTO> personDTOList = null;

            // Act
            List<Person> personList = _converter.ParseList(personDTOList);

            // Assert
            personList.Should().BeNull();
        }

        [Fact]
        public void ParseList_ShouldConvertPersonListToPersonDTOList()
        {
            // Arrange
            var personList = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "123 Main",
                    Gender = "Male",
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Address = "456 Elm",
                    Gender = "Female",
                },
            };

            var ExpectedPersonDTOList = new List<PersonDTO>
            {
                new PersonDTO
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "123 Main",
                    Gender = "Male",
                },
                new PersonDTO
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Address = "456 Elm",
                    Gender = "Female",
                },
            };

            // Act
            var personDTOList = _converter.ParseList(personList);

            // Assert
            personDTOList.Should().NotBeNull();
            personDTOList.Count.Should().Be(ExpectedPersonDTOList.Count);

            personDTOList[0].Should().NotBeNull();
            personDTOList[0].Id.Should().Be(ExpectedPersonDTOList[0].Id);
            personDTOList[0].FirstName.Should().Be(ExpectedPersonDTOList[0].FirstName);
            personDTOList[0].LastName.Should().Be(ExpectedPersonDTOList[0].LastName);
            personDTOList[0].Address.Should().Be(ExpectedPersonDTOList[0].Address);
            personDTOList[0].Gender.Should().Be(ExpectedPersonDTOList[0].Gender);

            personDTOList[1].Should().NotBeNull();
            personDTOList[1].Id.Should().Be(ExpectedPersonDTOList[1].Id);
            personDTOList[1].FirstName.Should().Be(ExpectedPersonDTOList[1].FirstName);
            personDTOList[1].LastName.Should().Be(ExpectedPersonDTOList[1].LastName);
            personDTOList[1].Address.Should().Be(ExpectedPersonDTOList[1].Address);
            personDTOList[1].Gender.Should().Be(ExpectedPersonDTOList[1].Gender);
        }
        [Fact]
        public void Parse_NullListPerson_ShouldReturnNull()
        {
            // Arrange
            List<Person> personList = null;

            // Act
            List<PersonDTO> personDTOList = _converter.ParseList(personList);

            // Assert
            personDTOList.Should().BeNull();
        }
    } 
}
