using Souqna.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Souqna.Data.Enums.ProductEnums;

namespace Souqna.Data.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> SearchAsync(string name);//ÏÇáÉ ÈÍË Úä ÇáãäÊÌÇÊ ÍÓÈ ÇáÇÓã

        Task<IEnumerable<Product>> GetAllAsync();//ÏÇáÉ áÌáÈ ÌãíÚ ÇáãäÊÌÇÊ
        Task<IEnumerable<Product>> GetAllApprovedAsync();//ÏÇáÉ áÌáÈ ÌãíÚ ÇáãäÊÌÇÊ ÇáãŞÈæáÉ
        Task<Product> GetByIdAsync(Guid productId);//ÏÇáÉ áÌáÈ ãäÊÌ ÍÓÈ ãÚÑİå
        Task AddAsync(Product product);//ÏÇáÉ áÅÖÇİÉ ãäÊÌ ÌÏíÏ
        void Update(Product product);//ÏÇáÉ áÊÍÏíË ãäÊÌ ãæÌæÏ
        Task DeleteAsync(Guid productId);//ÏÇáÉ áÍĞİ ãäÊÌ ÍÓÈ ãÚÑİå
        Task<IEnumerable<Product>> GetByUserIdAsync(string userId);//ÏÇáÉ áÌáÈ ÇáãäÊÌÇÊ ÇáÎÇÕÉ ÈãÓÊÎÏã ãÚíä ÍÓÈ ãÚÑİå
        Task<IEnumerable<Product>> FilterAsync(DateTime? releaseDate, ProductCategory? category, bool? isAvailable);//ÏÇáÉ áÊÕİíÉ ÇáãäÊÌÇÊ ÍÓÈ ÊÇÑíÎ ÇáÅÕÏÇÑ¡ ÇáİÆÉ¡ æÇáÊæÇİÑ


        // ? ÅÖÇİÉ ÇáãíËæÏ ÇáÌÏíÏÉ
        Task<IEnumerable<Product>> GetByCategoryAsync(ProductCategory category, Guid? excludeId = null);// ÏÇáÉ áÌáÈ ÇáãäÊÌÇÊ ÍÓÈ ÇáİÆÉ¡ ãÚ ÅãßÇäíÉ ÇÓÊÈÚÇÏ ãäÊÌ ãÚíä ÈäÇÁğ Úáì ãÚÑİå
    }



}