using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIngWebApp.Shared
{
    public interface ICrudService<TFormViewModel, TListViewModel, TKey, TBaseIndexModel>
        where TBaseIndexModel : BaseIndexModel
    {
        public Task<IndexViewModel<TListViewModel>> GetPageAsync(TBaseIndexModel vm);

        public Task<TFormViewModel> GetAsync(TKey id);

        public Task<TKey> PostAsync(TFormViewModel selectedItem);
    }

}
