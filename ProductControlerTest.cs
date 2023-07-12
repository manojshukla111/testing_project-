using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Unit_Test.Controllers;
using Unit_Test.Models;

namespace Unit_Test_Main
{
   public class ProductControlerTest
    {
        [Fact]
       public void Test_index_ProductCount() {
            // aarange 
            var controller = new ProductController();
            var result = controller.CreateProducts();
            // assert 
            Assert.Equal(3, result); // fail here count 00 de rha
        }

        [Fact]
        public void Test_details() { 
         var controller= new ProductController();
         var result= (controller.Details(2) as ViewResult);
            Assert.Equal("Details", result?.ViewName);

        }
        [Fact]
        public void Test_detail_ReDirectToIndex()
        {
            var controller= new ProductController(); 
            var result= (RedirectToActionResult)(controller.Details(0));
            Assert.Equal("Index", result.ActionName);
        }
    }
}
