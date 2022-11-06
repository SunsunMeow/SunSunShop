using SunSun.Model.Models;
using SunSun.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunSun.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory,PostCategoryViewModel postCategoryVM)
        {
            postCategory.ID = postCategoryVM.ID;
            postCategory.Name = postCategoryVM.Name;
            postCategory.Description = postCategoryVM.Description;
            postCategory.Image = postCategoryVM.Image;
            postCategory.Alias = postCategoryVM.Alias;
            postCategory.ParentID = postCategoryVM.ParentID;
            postCategory.DisplayOrder = postCategoryVM.DisplayOrder;
            postCategory.HomeFlag = postCategoryVM.HomeFlag;

            postCategory.UpdatedBy = postCategoryVM.UpdatedBy;
            postCategory.CreatedBy = postCategoryVM.CreatedBy;
            postCategory.UpdatedBy = postCategoryVM.UpdatedBy;
            postCategory.CreatedBy = postCategoryVM.CreatedBy;
            postCategory.MetaDescription = postCategoryVM.MetaDescription;
            postCategory.MetaKeyword = postCategoryVM.MetaKeyword;
        }
        public static void UpdatePost(this Post post,PostViewModel postViewModel)
        {
            post.ID = postViewModel.ID;
            post.Name = postViewModel.Name;
            post.Description = postViewModel.Description;
            post.Image = postViewModel.Image;
            post.Alias = postViewModel.Alias;
            post.Content = postViewModel.Content;
            post.HomeFlag = postViewModel.HomeFlag;
            post.HotFlag = postViewModel.HotFlag;
            post.CategoryID = postViewModel.CategoryID;
            post.ViewCount = postViewModel.ViewCount;

            post.UpdatedBy = postViewModel.UpdatedBy;
            post.CreatedBy = postViewModel.CreatedBy;
            post.UpdatedBy = postViewModel.UpdatedBy;
            post.CreatedBy = postViewModel.CreatedBy;
            post.MetaDescription = postViewModel.MetaDescription;
            post.MetaKeyword = postViewModel.MetaKeyword;
        }
    }
    
}