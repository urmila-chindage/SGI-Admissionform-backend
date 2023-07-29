using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGIAdmissionForm.DAL;
using System.Threading.Tasks;
using System;
using SGIAdmissionForm.Model.AdmissionForm;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace SGIAdmissionForm.Controllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class AdmissionFormController : ControllerBase
    {
        private readonly IAdmissionForm _admissionForm;
        private readonly IWebHostEnvironment webHostEnvironment;
        private string newUserJson;

        public AdmissionFormController(IAdmissionForm admissionForm,IWebHostEnvironment webHostEnvironment)
        {
            _admissionForm = admissionForm;
            this.webHostEnvironment= webHostEnvironment;
        }
      
        [HttpPost]
       
        public async Task<IActionResult> InsertRecord(AdmissionFormRequest request)
        {
            InsertAdmissionResponse response = new InsertAdmissionResponse();
            try
            {
                response = await _admissionForm.InsertRecord(request);             
             
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception occured " + ex.Message;
            }

            return Ok(response);
        }

        [HttpPut("UploadImage")]
        public async Task<IActionResult> UploadImage(IFormFile formFile, string FullName)
        {
            InsertAdmissionResponse response = new InsertAdmissionResponse();
            try
            {              
                string Filepath = GetFilePath(FullName);
                if (!System.IO.Directory.Exists(Filepath))
                {
                    System.IO.Directory.CreateDirectory(Filepath);
                }
                string image = Filepath + "\\" + FullName + ".jpeg";
                if (!System.IO.File.Exists(image))
                {
                    System.IO.File.Delete(image);
                }
                using (FileStream stream = System.IO.File.Create(image))
                {
                    await formFile.CopyToAsync(stream);
                    response.IsSuccess = true;
                    response.Message = "Uploaded successfully.";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
            }
            return Ok(response);
        }

        [NonAction]
        public string GetFilePath(string FullName)
        {
            return this.webHostEnvironment.WebRootPath + "C:\\Users\\GS\\source\\repos\\SGIAdmissionForm\\SGIAdmissionForm\\Upload\\StudentPhoto\\" + FullName;
        }
      
    }

   
}
