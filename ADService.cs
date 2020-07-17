using System.Security.Claims;
using System.Security.Principal;

namespace url_shorten_api.Helpers
{
    public class ADService
    {
        public bool CheckGroupMembership(ClaimsPrincipal User, string GroupName)
        {


            bool check = false;
            var user = (WindowsIdentity)User.Identity;
            if (user.Groups != null)
            {
                foreach (var group in user.Groups)
                {
                    check = group.Translate(typeof(NTAccount)).ToString().Contains(GroupName);
                    if (check)
                        break;
                }
            }
            return check;

        }

    }
}