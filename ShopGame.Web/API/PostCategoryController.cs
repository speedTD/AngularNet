using AutoMapper;
using ShopGame.Data.intefacestruct;
using ShopGame.Data.Repositories;
using ShopGame.Model.Models;
using ShopGame.Service;
using ShopGame.Web.Infastucture.Core;
using ShopGame.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShopGame.Web.Infastucture.Extendsions;

namespace ShopGame.Web.API
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiController
    {
        IPostCateGoryService _iPostCateGoryService;
      
        public PostCategoryController(IPostCateGoryService PostCateGoryService)
        {
            this._iPostCateGoryService = PostCateGoryService;
        }


        [Route("create")]
        public HttpResponseMessage Create(HttpResponseMessage request,PostCateGoryViewModel value)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {

            }
            else
            {

                PostCateGory key = new PostCateGory();
                key.UpdatePostCateGory(value);
                _iPostCateGoryService.Add(key);
                _iPostCateGoryService.SaveChange();
                response = Request.CreateResponse(HttpStatusCode.Created, value);
            }
       
            return response;
        }
        [Route("update")]
        public HttpResponseMessage Update(HttpResponseMessage request, PostCateGoryViewModel value)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {

            }
            else
            {
                var postcategoryD = _iPostCateGoryService.GetSingleByid(value.id);
                postcategoryD.UpdatePostCateGory(value);
                _iPostCateGoryService.Update(postcategoryD);
                _iPostCateGoryService.SaveChange();
                response = Request.CreateResponse(HttpStatusCode.OK, value);
            }

            return response;
        }

        public HttpResponseMessage Delete(HttpResponseMessage request, int value)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {

            }
            else
            {
                _iPostCateGoryService.Delete(value);
                _iPostCateGoryService.SaveChange();
                response = Request.CreateResponse(HttpStatusCode.OK, value);
            }

            return response;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpResponseMessage request)
        {
            HttpResponseMessage response = null;
          

            var list = _iPostCateGoryService.getAll();
            var listCateVM = Mapper.Map<List<PostCateGoryViewModel>>(list);
        
            response = Request.CreateResponse(HttpStatusCode.OK, listCateVM);
            return response;
        }
    }
}