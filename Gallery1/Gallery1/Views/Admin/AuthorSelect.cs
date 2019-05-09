using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gallery1.Models;

namespace Gallery1.Views.Admin
{
    public class AuthorSelect
    {
        EditModel editModel = new EditModel();
       
        public Author[] Author()
        {
           Author[] authorsArray = editModel.Authors.ToArray();
            return authorsArray;
        }
        
    }
}