using System.Security.Claims;

namespace İdentityAp.Models;

public static class ClaimStore
{
    public static List<Claim>claimsList = new List<Claim>()
    {
        new Claim("create", "True"),
        new Claim("edit", "True"),
        new Claim("delete", "True"),
        new Claim("superadmin", "True"),
    };
}