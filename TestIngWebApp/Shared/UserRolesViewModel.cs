using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIngWebApp.Shared
{
    public class UserRolesViewModel : ViewModelBase
    {

        //  readonly UserManager<ApplicationUser> userManager;

        private string _Id;

        public string Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                NotifyPropertyChanged();
            }
        }


        [Required(ErrorMessage = "User name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public bool IsEnabled { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select an option")]
        public int PartyId { get; set; }

        [Required(ErrorMessage = "Please select a Role")]
        public string RoleId { get; set; }
        public string RoleName { get; set; }

    }
}
