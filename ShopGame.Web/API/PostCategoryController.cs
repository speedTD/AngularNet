using ShopGame.Data.intefacestruct;
using ShopGame.Data.Repositories;
using ShopGame.Model.Models;
using ShopGame.Service;
using ShopGame.Web.Infastucture.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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



        public HttpResponseMessage Create(HttpResponseMessage request,PostCateGory value)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {

            }
            else
            {
                _iPostCateGoryService.Add(value);
                _iPostCateGoryService.SaveChange();
                response = Request.CreateResponse(HttpStatusCode.Created, value);
            }
       
            return response;
        }
        public HttpResponseMessage Update(HttpResponseMessage request, PostCateGory value)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {

            }
            else
            {
                _iPostCateGoryService.Update(value);
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
        
            response = Request.CreateResponse(HttpStatusCode.OK, list);
            return response;
        }
    }
}