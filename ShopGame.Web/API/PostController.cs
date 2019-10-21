using AutoMapper;
using ShopGame.Service;
using ShopGame.Web.Infastucture.Core;
using ShopGame.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopGame.Web.API
{
    [RoutePrefix("api/post")]
    public class PostController : BaseApiController
    {

        IpostService _iPostService; 

        public PostController(IpostService PostCateGoryService)
        {
            this._iPostService = PostCateGoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpResponseMessage request)
        {
            HttpResponseMessage response = null;


            var list = _iPostService.getAll();
            var listCateVM = Mapper.Map<List<PostViewModel>>(list);

            response = Request.CreateResponse(HttpStatusCode.OK, listCateVM);
            return response;
        }
    }
}