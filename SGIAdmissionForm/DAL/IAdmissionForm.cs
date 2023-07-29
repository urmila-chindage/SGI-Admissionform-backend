using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGIAdmissionForm.Model.AdmissionForm;
using System.Threading.Tasks;

namespace SGIAdmissionForm.DAL
{
    public interface IAdmissionForm
    {
        public Task<InsertAdmissionResponse> InsertRecord(AdmissionFormRequest request);
    }
}
