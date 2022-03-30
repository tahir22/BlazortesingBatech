using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIngWebApp.Shared
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public bool IsEnabled { get; set; }

        public int PartyId { get; set; }
        public string RoleId { get; set; }

        public static implicit operator ChangePasswordViewModel(UserRolesViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
