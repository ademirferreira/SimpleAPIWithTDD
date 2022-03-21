using System.Collections.Generic;
using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures;

public static class UsersFixture
{
    public static List<User> GetTestUsers() => new()
    {
        new User
        {
            Name = "Test User 1",
            Email = "test.user.1@productivedev.com",
            Address = new Address
            {
                Street = "123 Market St",
                City = "Somewere",
                ZipCode = "213124"
            }
        },
        new User
        {
            Name = "Test User 2",
            Email = "test.user.22@productivedev.com",
            Address = new Address
            {
                Street = "900 Main St",
                City = "Somewere",
                ZipCode = "213124"
            }
        },
        new User
        {
            Name = "Test User 3",
            Email = "test.user.3@productivedev.com",
            Address = new Address
            {
                Street = "108 Marple St",
                City = "Somewere",
                ZipCode = "213124"
            }
        },
    };
}