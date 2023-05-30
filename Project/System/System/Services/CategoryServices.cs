using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Controllers.Input;
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
        public bool EditCateItem(List<CategoryItemModel> itemdata);
        public bool DeleteCateItem(string id);

        public bool AddCateType(CategoryAccessControlModel accessControl);
        public bool RemoveCateType(CategoryAccessControlModel accessControl);
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

        public bool EditCateItem(List<CategoryItemModel> itemdata)
        {
            try
            {
                foreach(var item in itemdata)
                {
                    var iteminfo = _dataContext.item.Find(item.ItemID);
                    iteminfo.CategoryID = item.CategoryID;
                    _dataContext.item.Update(iteminfo);
                }

                _dataContext.SaveChanges ();
                return true;

            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public bool DeleteCateItem(string id)
        {
            try
            {   
                var iteminfo = _dataContext.item.Find(id);
                iteminfo.CategoryID = null;
                _dataContext.item.Update(iteminfo);
                _dataContext.SaveChanges();
            return true;
            }catch( Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool AddCateType(CategoryAccessControlModel accessControl)
        {
            try
            {
                var ac = new AccessControl
                {
                    categoryID = accessControl.CategoryID,
                    typeID = accessControl.TypeID
                };
                _dataContext.AccessControl.Add(ac);
                _dataContext.SaveChanges();
                return true;
            }catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool RemoveCateType(CategoryAccessControlModel accessControl)
        {
            try
            {
                var ac = new AccessControl
                {
                    categoryID = accessControl.CategoryID,
                    typeID = accessControl.TypeID
                };
                _dataContext.AccessControl.Remove(ac);
                _dataContext.SaveChanges();
                return true;
            }catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }


    }
}
