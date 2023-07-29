using Amazon.SecurityToken.Model;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace SGIAdmissionForm.Model.AdmissionForm
{
    public class AdmissionFormRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string AId { get; set; }
        public string FullName { get; set; }         
        public string Branch { get; set; }
        public string DOB { get; set; }
        public string StudentPhoto { get; set; }
        public string PhotoSign { get; set; }
        public string Gender { get; set; }
        public string AdharcardNo { get; set; }
        public string ContactStudent { get; set; }
        public string ContactParents { get; set; }
        public string Nationality { get; set; }

        public string Bloodgrp { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string Occupation { get; set; }
        public string MotherName { get; set; }

        public string Category { get; set; }

        public string MinorityTypeCandidature { get; set; }

        public string DisabilityTypeCandidature { get;set; }

        public string DefenceTypeCandidature { get; set; }

        public string CorrespondenceAddress { get; set; }

        public string CCityVillage { get; set; }

        public string CArea { get; set; }

        public string CPincode { get; set; }

        public string CTaluka { get; set; }

        public string CDistrict { get; set; }

        public string CState { get; set; }

        public string PermanentAddress { get; set; }
        public string PCityVillage { get; set; }

        public string PArea { get; set; }

        public string PPincode { get; set; }

        public string PTaluka { get; set; }

        public string PDistrict { get; set; }

        public string PState { get; set; }

        public string YrOfPassingSSC { get; set; }

        public string ObtainedMarksSSC { get;set; }

        public string MarksOutOfSSC { get; set; }

        public string PercentageOfMarksSSC { get; set; }
        
        public string YrOfPassingHSC { get; set; }
        
        public string ObtainedMarksHSC { get; set; }
        
        public string MarksOutOfHSC { get; set; }
        
        public string PercentageOfMarksHSC { get; set; }
        
        public string YrOfPassingOther { get; set; }
        
        public string ObtainedMarksOther { get; set; }
        
        public string MarksOutOfOther { get; set; }
        
        public string PercentageOfMarksOther { get; set; }
        

        public string ApplicationNoMHTCET { get; set; }
        
        public string YearOfPassingMHTCET { get; set; }
        
        public string MathematicsScoreMHTCET { get; set; }
        
        public string PhysicsScoreMHTCET { get; set; }
        
        public string ChemistryScoreMHTCET { get; set; }
        
        public string TotalScoreMHTCET { get; set; }

        public string ApplicationNoJEEMAins { get; set; }

        public string YearOfPassingJEEMAins { get; set; }

        public string MathematicsScoreJEEMAins { get; set; }

        public string PhysicsScoreJEEMAins { get; set; }

        public string ChemistryScoreJEEMAins { get; set; }

        public string TotalScoreJEEMAins { get; set; }


        public Boolean AdmissionLetter { get; set; } 

        public Boolean SSCMarksheet { get; set; }

        public Boolean HSCMarksheet { get; set; }

        public Boolean MHTCETScoreCard { get; set; }

        public Boolean JEEMains { get; set; }

        public Boolean DipBSC { get; set; }

        public Boolean LeavingTransferCert { get; set; }

        public Boolean NationalityDomicileBirt { get; set; }

        public Boolean GAPCert { get; set; } 

        public Boolean CasteCertificate { get; set; }

        public Boolean CasteValidityCertificate { get; set; }

        public Boolean Noncreamylayer { get; set; }

        public Boolean IncomeCerificate { get; set; }

        public Boolean CertiDefense { get; set; }

        public Boolean DisabilityCert { get; set; }

        public Boolean AdharCard { get; set; }

        public string Remark { get; set; }



        public Boolean SignatureStudent { get; set; }

        public Boolean SignatureParent { get; set; }
        public string CreateDate { get; set; }  

    }
    public class InsertAdmissionResponse
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    } 
}
