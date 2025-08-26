using Souqna.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Souqna.Data.Enums.ProductEnums;

namespace Souqna.Data.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> SearchAsync(string name);//���� ��� �� �������� ��� �����

        Task<IEnumerable<Product>> GetAllAsync();//���� ���� ���� ��������
        Task<IEnumerable<Product>> GetAllApprovedAsync();//���� ���� ���� �������� ��������
        Task<Product> GetByIdAsync(Guid productId);//���� ���� ���� ��� �����
        Task AddAsync(Product product);//���� ������ ���� ����
        void Update(Product product);//���� ������ ���� �����
        Task DeleteAsync(Guid productId);//���� ���� ���� ��� �����
        Task<IEnumerable<Product>> GetByUserIdAsync(string userId);//���� ���� �������� ������ ������� ���� ��� �����
        Task<IEnumerable<Product>> FilterAsync(DateTime? releaseDate, ProductCategory? category, bool? isAvailable);//���� ������ �������� ��� ����� ������ѡ ����ɡ ��������


        // ? ����� ������� �������
        Task<IEnumerable<Product>> GetByCategoryAsync(ProductCategory category, Guid? excludeId = null);// ���� ���� �������� ��� ����ɡ �� ������� ������� ���� ���� ����� ��� �����
    }



}