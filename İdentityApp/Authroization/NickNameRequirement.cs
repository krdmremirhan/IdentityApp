using Microsoft.AspNetCore.Authorization;

namespace İdentityAp.Authroization;

public class NickNameRequirement :IAuthorizationRequirement
{
    public string NickName { get; set; }
    public NickNameRequirement(string nickName)
    {
        NickName = nickName;
    }
}