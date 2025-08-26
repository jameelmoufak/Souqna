using Microsoft.AspNetCore.Mvc;
using Souqna.Data.Repositories;

namespace Souqna.Components
{
    public class ProductListViewComponent : ViewComponent
    {
        private readonly IProductRepository repository;

        public ProductListViewComponent(IProductRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Products = await repository.GetAllAsync();
            return await Task.FromResult<IViewComponentResult>(View(Products));
        }
    }
}
