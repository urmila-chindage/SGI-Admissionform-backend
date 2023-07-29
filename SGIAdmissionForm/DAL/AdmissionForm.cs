using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Threading.Tasks;
using System;
using SGIAdmissionForm.Model.AdmissionForm;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SGIAdmissionForm.DAL
{
    public class AdmissionForm : IAdmissionForm
    {
        private readonly IConfiguration _configuration;
        private readonly MongoClient _client;
        private readonly IMongoCollection<AdmissionFormRequest> _admissionForm;
        
        public AdmissionForm(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = new MongoClient(_configuration[key: "DatabaseSettings:ConnectionString"]);
            var _MongoDatabase = _client.GetDatabase(_configuration[key: "DatabaseSettings:DatabaseName"]);
            _admissionForm = _MongoDatabase.GetCollection<AdmissionFormRequest>(_configuration[key: "DatabaseSettings:CollectionName"]);
        }

        public async Task<InsertAdmissionResponse> InsertRecord(AdmissionFormRequest request)
        {
            InsertAdmissionResponse response = new InsertAdmissionResponse();
            response.IsSuccess = true;
            response.Message = "Record inserted Successfully";
            try
            {
                //var  email=request.EmailStudent.ToString();

                var yrofpassingssc = request.YrOfPassingSSC.ToString();
                var mrksobtssc=request.ObtainedMarksSSC.ToString();
                var mrksoutoffssc=request.MarksOutOfSSC.ToString();
                var perssc=request.PercentageOfMarksSSC.ToString();

                var yrofpassinghsc=request.YrOfPassingHSC.ToString();
                var mrksobthsc=request.ObtainedMarksHSC.ToString();
                var mrksoutoffhsc=request.MarksOutOfHSC.ToString();
                var perhsc=request.PercentageOfMarksHSC.ToString();

                var yrofpassingother = request.YrOfPassingOther.ToString();
                var mrksobtother = request.ObtainedMarksOther.ToString();
                var mrksoutoffother = request.MarksOutOfOther.ToString();
                var perhother = request.PercentageOfMarksOther.ToString();

                var mhtcetmaths = request.MathematicsScoreMHTCET.ToString();
                var mhtcetphysics = request.PhysicsScoreMHTCET.ToString();
                var mhtcetchemistry = request.ChemistryScoreMHTCET.ToString();
                var mhtcettotoal = request.TotalScoreMHTCET.ToString();
                var mhtcetyrsofpass= request.YearOfPassingMHTCET.ToString();

                var jeemainsmaths = request.MathematicsScoreJEEMAins.ToString();
                var jeemainsphysics = request.PhysicsScoreJEEMAins.ToString();
                var jeemainschemistry = request.ChemistryScoreJEEMAins.ToString();
                var jeemainstotoal = request.TotalScoreJEEMAins.ToString();
                var jeemainsyrsofpass = request.YearOfPassingJEEMAins.ToString();

                request.CreateDate = DateTime.Now.ToString();               
                await _admissionForm.InsertOneAsync(request);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception occured " + ex.Message;
            }
            return response;
        }
    }
}
