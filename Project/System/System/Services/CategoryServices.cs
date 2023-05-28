using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Model;
using Server.Model.Dto;
using Server.Model.Entity;

namespace Server.Services
{
    public interface ICategoryServices
    {
        public IEnumerable<Category> GetAll();
        public CategoryItemDto GetByID(string id);
        public bool CreateCate(Category category);
        public bool EditCate(Category category);
    }



    public class CategoryServices : ICategoryServices
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public CategoryServices(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public IEnumerable<Category> GetAll()
        {
            return _dataContext.category.Distinct();
            
        }

        public CategoryItemDto GetByID(string id)
        {
            var result = (from item in _dataContext.category
                join itemsData in _dataContext.item on item.CategoryID equals itemsData.CategoryID
                where item.CategoryID == id
                select _mapper.Map<CateItemInfo>(itemsData)).AsNoTracking().ToList();
            var cateInfo = _dataContext.category.Find(id);
            var CateItemDto = new CategoryItemDto
            {
                CateId = id,
                CateName = cateInfo.name,
                remark = cateInfo.remark,
                cateItemInfo = result
            };

            return CateItemDto;
        }

        public bool CreateCate(Category category)
        {
            try
            {
                _dataContext.category.Add(category);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public bool EditCate(Category category)
        {
            try
            {
                var existingCate = _dataContext.category.Find(category.CategoryID);

                if (existingCate == null)
                {
                    return false;
                }

                if (category.name != null)
                {
                    existingCate.name = category.name;
                }

                if (category.remark != null)
                {
                    existingCate.remark = category.remark;
                }

                _dataContext.category.Update(existingCate);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }




    }
}
