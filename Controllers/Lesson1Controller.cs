using learn.Models; //有這個就可以直接用models

using Microsoft.AspNetCore.Mvc;

namespace learn.Controllers
{
    public class Lesson1Controller : Controller
    {
        public IActionResult Index()
        {
          return View();
        }
        public IActionResult Index1A()
        {
            return View("Index");
        }
        public string Index1B()
        {
            return "sdswsad --<h3>string</h3>";//用string 船字串
        }
        public IActionResult Index1C()
        {
            return Content("用Content船"); //content 船字串
        }
        public IActionResult Index1D()
        {
            return Redirect("https://www.google.com.tw/"); //導向google
        }
        public IActionResult Index2()
        {
            return View(); 
        }
        public IActionResult Index8()
        {
            return View(); 
        }
        public IActionResult Index3()
        {
            ViewData["A"]="sd";
            ViewBag.B = "zx";
            TempData["C"] = "aaa";
            return View();
        }
        public IActionResult Index4()
        {
            var uname = new Class1();
            uname.UserName = "字串D在models的class1裡面";

            return View(uname);
            //把它拿過來才能用
        }
        public IActionResult Index5()
        {
            List<Models.Class1> myList = new List<Class1>
            {
                new Models.Class1{UserName="1dsa"},
                new Models.Class1{UserName="2dsa"},
                new Models.Class1{UserName="3dsa"},
                new Models.Class1{UserName="4dsa"},

            };
            return View(myList);
        }
            public IActionResult Index6()
            {
            List<Models.Class2> myList = new List<Class2>
            {
                new Class2{Name="1dsa", Phonenumber="1243",Id=1234,Address="sdfa"},
                new Class2{Name="1dsa", Phonenumber="1243",Id=1234,Address="sdfa"},
                new Class2{Name="1dsa", Phonenumber="1243",Id=1234,Address="sdfa"},
                new Class2{Name="1dsa", Phonenumber="1243",Id=1234,Address="sdfa"},


            };
                return View(myList);

            }
        public IActionResult create()
        {
            
            return View();

        }
        public IActionResult Edit()
        {

            return View();

        }
        public IActionResult Delete()
        {

            return View();

        }
        public IActionResult Details()
        {

            return View();

        }
    }

    }

