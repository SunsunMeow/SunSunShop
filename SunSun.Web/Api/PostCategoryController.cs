using AutoMapper;
using SunSun.Model.Models;
using SunSun.Service;
using SunSun.Web.Infrastructure.Core;
using SunSun.Web.Infrastructure.Extensions;
using SunSun.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SunSun.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        public HttpResponseMessage POST(HttpRequestMessage httpRequest, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(httpRequest, () =>
            {
                HttpResponseMessage httpResponse = null;
                if (ModelState.IsValid)
                {
                    httpRequest.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostCategory postCategory = new PostCategory();
                    postCategory.UpdatePostCategory(postCategoryVm);

                    _postCategoryService.Add(postCategory);
                    _postCategoryService.Save();
                    
                    httpResponse = httpRequest.CreateResponse(HttpStatusCode.Created);
                }
                return httpResponse;
            });

        }
        public HttpResponseMessage PUT(HttpRequestMessage httpRequest, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(httpRequest, () =>
            {
                HttpResponseMessage httpResponse = null;
                if (ModelState.IsValid)
                {
                    httpRequest.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.ID);
                    postCategoryDb.UpdatePostCategory(postCategoryVm);
                    _postCategoryService.Update(postCategoryDb);
                    _postCategoryService.Save();

                    httpResponse = httpRequest.CreateResponse(HttpStatusCode.OK);
                }
                return httpResponse;
            });

        }
        public HttpResponseMessage Delete(HttpRequestMessage httpRequest, int id)
        {
            return CreateHttpResponse(httpRequest, () =>
            {
                HttpResponseMessage httpResponse = null;
                if (ModelState.IsValid)
                {
                    httpRequest.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();

                    httpResponse = httpRequest.CreateResponse(HttpStatusCode.OK);
                }
                return httpResponse;
            });

        }
        [Route("getall")]
        public HttpResponseMessage GET(HttpRequestMessage httpRequest)
        {
            return CreateHttpResponse(httpRequest, () =>
            {
                var listCategory = _postCategoryService.GetAll();
                var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(listCategory);
                HttpResponseMessage httpResponse = httpRequest.CreateResponse(HttpStatusCode.OK, listCategory);
                
                return httpResponse;
            });

        }

    }
}