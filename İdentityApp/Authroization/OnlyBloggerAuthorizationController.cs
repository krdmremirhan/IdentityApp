using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İdentityAp.Authroization
{
    public class OnlyBloggerAuthorizationController : AuthorizationHandler<OnlyBloggerAuthorizationController>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OnlyBloggerAuthorizationController requirement)
        {
            if(context.User.IsInRole("Blogger"))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}