using ShopGame.Model.Models;
using ShopGame.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopGame.Web.Infastucture.Extendsions
{
    public static class EntityExtenstions
    {
        public static void UpdatePostCateGory(this PostCateGory p1, PostCateGoryViewModel p2)
        {
            p1.id = p2.id;
            p1.name = p2.name;
            p1.alias = p2.alias;
            p1.displayoder = p2.displayoder;
            p1.metaDesciption = p2.metaDesciption;
            p1.image = p2.image;
            p1.metakeyword = p2.metakeyword;
            p1.status = p2.status;
            p1.parentid = p2.parentid;
            p1.homeflag = p2.homeflag;
            p1.createdat = p2.createdat;
            p1.createby = p2.createby;
            p1.updatedat = p2.updatedat;
            p1.updateby = p2.updateby;

         }


        public static void UpdatePost(this Post p1, PostViewModel p2)
        {
            p1.id = p2.id;
            p1.name = p2.name;
            p1.alias = p2.alias;
            p1.viewcount = p2.viewcount;
            p1.desciption = p2.desciption;
            p1.content = p2.content;
            p1.categoryid = p2.categoryid;
            p1.metaDesciption = p2.metaDesciption;
            p1.image = p2.image;
            p1.metakeyword = p2.metakeyword;
            p1.status = p2.status;        
            p1.homeflag = p2.homeflag;
            p1.createdat = p2.createdat;
            p1.createby = p2.createby;
            p1.updatedat = p2.updatedat;
            p1.updateby = p2.updateby;

        }
    }
}