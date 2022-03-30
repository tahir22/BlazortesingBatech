using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIngWebApp.Shared
{
    public interface IInternalUserService
       : ICrudService<WeatherForecast, WeatherForecast, string, UserAdditionalValueViewModel>
    {
        public Task<bool> ChangePassword(ChangePasswordViewModel changePasswordViewModel);
        public Task<IEnumerable<SelectListItem>> GetEmployees(string userId);
        Task<List<WeatherForecast>> GetRolesAsync();
    }
}
