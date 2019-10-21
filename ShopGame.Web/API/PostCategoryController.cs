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

using ShopGame.Web.Infastucture.Extendsions;
using System.Threading.Tasks;

using System.Web.Http;
using System.Collections;

namespace ShopGame.Web.API
{
    [RoutePrefix("api/postcategory")]

    public class PostCategoryController : ApiController
    {
        readonly IPostCateGoryService _iPostCateGoryService;

        public PostCategoryController(IPostCateGoryService PostCateGoryService)
        {
            this._iPostCateGoryService = PostCateGoryService;
        }


        /* [Route("create")]
         public HttpResponseMessage Create(HttpResponseMessage request,[FromBody]PostCateGory value)
         {
             HttpResponseMessage response = null;
             if (ModelState.IsValid)
             {

             }
             else
             {

                 PostCateGory key = new PostCateGory();
                 key.UpdatePostCateGory(value);
                 _iPostCateGoryService.Add(value);
                 _iPostCateGoryService.SaveChange();
                 response = Request.CreateResponse(HttpStatusCode.Created, value);
             }

             return response;
         }
       */
        [HttpPost]
        [AllowAnonymous]
        [Route("create")]
        public async Task<HttpResponseMessage> Create(HttpRequestMessage req, [FromBody]PostCateGoryViewModel model)
        {
            var result = true;
            if (ModelState.IsValid)
            {

                try
                {
                    PostCateGory key = new PostCateGory();
                    key.UpdatePostCateGory(model);
                    _iPostCateGoryService.Add(key);


                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            return req.CreateResponse(HttpStatusCode.OK, result);
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

        [Route("getall1")]
        public IEnumerable getall()
        {
            return _iPostCateGoryService.getAll();
        }


    }
}