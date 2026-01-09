using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    // JWT token service contract
    public interface ITokenService
    {
        // Create JWT token
        string CreateToken(AppUser user);
    }
}
