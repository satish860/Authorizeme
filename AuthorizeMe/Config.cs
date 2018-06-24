using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace AuthorizeMe
{
    public static class Config
    {
        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>
            {
                new TestUser{
                    SubjectId = "2763cd5c-04ee-4cc5-987d-728398c74063",
                    Username ="satish860",
                    Password = "superscretpassword",
                    Claims= new[]
                    {
                        new Claim("given_name","satish"),
                        new Claim("family_name","satish")
                    }
                },
                new TestUser{
                    SubjectId = "25a17028-611e-4571-8ad3-fa867d76d8a9",
                    Username ="suganya",
                    Password = "superscretpassword",
                    Claims= new[]
                    {
                        new Claim("given_name","suganya"),
                        new Claim("family_name","satish")
                    }
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
              new IdentityResources.OpenId(),
              new IdentityResources.Profile()
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>();

        }
    }
}
