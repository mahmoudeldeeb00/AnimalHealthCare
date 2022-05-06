using ProjectBackEndDemo.Areas.Diseases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Diseases.Rep
{
    public interface IDiseaseRep
    {
        public List<DieseaseVM> GetAllDiseases(int AnimalId);
        public List<DieseaseVM> GetAllDiseases(int AnimalId , string search);
        public DieseaseVM GetDieaseById( int id );
        public void CreateDisease(DieseaseVM model);
        public List<string> DiseaseAutoCmplt(string prefix);

        public List<MedicineVM> GetAllMedicines();
        public List<MedicineVM> GetAllMedicines(string search);
        public MedicineVM GetMedicineById(int id);
        public void CreateMedicine(MedicineVM model);


        public List<SymptomVM> GetAllSymptoms();
        public List<SymptomVM> GetAllSymptoms(string search);
        public SymptomVM GetSymptomById(int id);
        public void CreateSymptom(SymptomVM model);





        public void CreateFAQ(FAQVM model);
        public List<FAQVM> GetFAQS();
        public List<FAQVM> GetSearchedFAQS(string search);
    }
}
