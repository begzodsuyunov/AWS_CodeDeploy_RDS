using _00010358.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _00010358.Controllers
{
    public class StudentController : Controller
    {
        //Hosted web API REST service base url
        Uri baseAdd = new Uri("http://ec2-13-231-163-184.ap-northeast-1.compute.amazonaws.com/");
        HttpClient clnt;

        public StudentController()
        {
            clnt = new HttpClient();
            clnt.BaseAddress = baseAdd;
        }

        // GET: StudentController
        public async Task<ActionResult> Index()
        {
            //Hosted web API REST Service base url
            string Baseurl = "http://ec2-13-231-163-184.ap-northeast-1.compute.amazonaws.com/";
            List<Student> StuInfo = new List<Student>();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new
                MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource using HttpClient
                HttpResponseMessage Res = await client.GetAsync("api/Student");

                //Checking the response is successful or not which is sent HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var StResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing the Student list
                    StuInfo = JsonConvert.DeserializeObject<List<Student>>(StResponse);
                }
                //returning the Product list to view
                return View(StuInfo);
            }
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            //Creating GET request to get single student
            Student modelStu = new Student();
            //making GET request with id
            HttpResponseMessage resStudent = clnt.GetAsync(clnt.BaseAddress + "api/Student/" + id).Result;
            //Checking the response is successful or not which is sent HttpClient
            if (resStudent.IsSuccessStatusCode)
            {

                //Storing the response details recieved from web api
                string info = resStudent.Content.ReadAsStringAsync().Result;
                //Deserializing the response recieved from web api and storing the student information
                modelStu = JsonConvert.DeserializeObject<Student>(info);
            }

            return View(modelStu);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student stu)
        {
            //Passing data as json string
            string info = JsonConvert.SerializeObject(stu);
            //creating the content of the string to pass as Http content later
            StringContent cont = new StringContent(info, Encoding.UTF8, "application/json");
            //Making post request
            HttpResponseMessage resStudent = clnt.PostAsync(clnt.BaseAddress + "api/Student", cont).Result;
            //Checking the response is successful
            if (resStudent.IsSuccessStatusCode)
                return RedirectToAction(nameof(Index));

            return View();
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            //Creating GET request to get single student
            Student modelStu = new Student();
            //Sending request to find web api REST service resource using HttpClient
            HttpResponseMessage resStudent = clnt.GetAsync(clnt.BaseAddress + "api/Student/" + id).Result;
            //Checking the response is successful or not which is sent HttpClient 
            if (resStudent.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api
                string info = resStudent.Content.ReadAsStringAsync().Result;
                //Deserializing the response recieved from web api and storing the student information
                modelStu = JsonConvert.DeserializeObject<Student>(info);
            }

            return View(modelStu);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student stu)
        {
            //Passing data as json string
            string info = JsonConvert.SerializeObject(stu);
            StringContent cont = new StringContent(info, Encoding.UTF8, "application/json");
            //Sending request to find web api REST service resource using HttpClient
            HttpResponseMessage resStudent = clnt.PutAsync(clnt.BaseAddress + "api/Student/" + stu.StudentID, cont).Result;
            //Checking the response is successful
            if (resStudent.IsSuccessStatusCode)
                return RedirectToAction(nameof(Index));
            return View();
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            //Creating GET request to get single student
            Student modelStu = new Student();
            //Sending request to find web api REST service resource using HttpClient
            HttpResponseMessage resStudent = clnt.GetAsync(clnt.BaseAddress + "api/Student/" + id).Result;
            //Checking the response is successful or not which is sent HttpClient
            if (resStudent.IsSuccessStatusCode)
            {
                //Storing the response details recieved from web api
                string info = resStudent.Content.ReadAsStringAsync().Result;
                //Deserializing the response recieved from web api and storing the student information
                modelStu = JsonConvert.DeserializeObject<Student>(info);
            }

            return View(modelStu);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student stu)
        {
            try
            {
                //Sending request to find web api REST service resource using HttpClient
                HttpResponseMessage resStudent = clnt.DeleteAsync(clnt.BaseAddress + "api/Student/" + id).Result;
                //Checking the response is successful
                if (resStudent.IsSuccessStatusCode)
                    return RedirectToAction(nameof(Index));
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
