using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestIngWebApp.Shared;

namespace TestIngWebApp.Client.Services
{
    public class InternalUserService : ServiceBase, IInternalUserService
    {
        public InternalUserService(ApiService apiService, ILogger<InternalUserService> logger) : base(apiService, logger)
        {

        }
        public override string ControllerPath => "v1/WeatherForecast";

        public async Task<bool> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            return await ApiService.PostFromJsonAsync<bool, ChangePasswordViewModel>($"{ControllerPath}/ChangePassword", changePasswordViewModel);
        }

        public async Task<WeatherForecast> GetAsync(string id)
        {
            return await ApiService.GetFromJsonAsync<WeatherForecast>($"{ControllerPath}/Get?id={id}");
        }

        public async Task<IEnumerable<SelectListItem>> GetEmployees(string userId)
        {
            return await ApiService.GetFromJsonAsync<IEnumerable<SelectListItem>>($"{ControllerPath}/GetEmployees?userId={userId}");
        }

        public async Task<IndexViewModel<WeatherForecast>> GetPageAsync(UserAdditionalValueViewModel vm)
        {
            
            return await ApiService.GetFromJsonAsync<IndexViewModel<WeatherForecast>>($"{ControllerPath}/Get?{vm.ToQueryString()}");
        }

        public async Task<List<WeatherForecast>> GetRolesAsync()
        {
            return await ApiService.GetFromJsonAsync<List<WeatherForecast>>($"{ControllerPath}/GetRoles");
        }

        public async Task<string> PostAsync(WeatherForecast selectedItem)
        {
            return await ApiService.PostFromJsonAsync<string, WeatherForecast>($"{ControllerPath}/Post", selectedItem);
        }
    }
}
