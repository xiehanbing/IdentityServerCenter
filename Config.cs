using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServerCenter
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetResource()
        {
            return new List<ApiResource>{
                  new ApiResource("api","MyApi")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return  new List<Client>()
            {
                new Client()
                {
                    ClientId = "client",
                    AllowedGrantTypes =GrantTypes.ClientCredentials,
                    ClientSecrets ={ new Secret("secret".Sha256())},
                    AllowedScopes ={"api"}
                },
                new Client()
                {
                    ClientId = "pwdclient",
                    AllowedGrantTypes =GrantTypes.ResourceOwnerPassword,
                    ClientSecrets ={ new Secret("secret".Sha256())},
                    AllowedScopes ={"api"}
                }
            };
        }

        public static  List<TestUser> GetUser()
        {
            return   new List<TestUser>()
            {
                new TestUser()
                {
                    SubjectId = "1",
                    Username = "jesse",
                    Password = "123456"
                }
            };
        }
    }
}