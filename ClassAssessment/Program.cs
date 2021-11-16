using System;
using System.Collections.Generic;


namespace ClassAssessment
{
    class Program
    {
        static void Main(string[] args)
        {             
        }
        public class RoyalCrestCollegeFeesDetails
        {
            public List<Students> allEnrolledStudents { get; set; }
          public  double TotalHostelBenefits(List<IHostelBeneficial> beneficiable)
            {
                var totalBeneficiable = 0d;
                foreach (var students in beneficiable )
                {
                    totalBeneficiable += students.GetHostelBenefits();
                    

                }
                return totalBeneficiable;
            }

            public      double PayTotalTuition(List<ITuition> tuition)
            {
                var totalTuition = 0d;
                foreach (var students in tuition )
                {
                    totalTuition += students.PayTuitionFee();
                }
                return totalTuition;
            }

            public class Students
            {

                public int StudentId { get; set; }
                public string StudentName { get; set; }
                public string Department { get; set; }
                 
               

                
            }

            public class Day : Students , ITuition
            {
                public double PayTuitionFee()
                {
                    return 0;
                }


                
            }

            public class Boarding : Students , ITuition, IHostelBeneficial
            {
                public double PayTuitionFee()
                {
                    return 0;
                }

              
                public double GetHostelBenefits()
                {
                    return 0;
                }
            }

            
        }

        public interface ITuition
        {
            public double PayTuitionFee();

        }

        public interface IHostelBeneficial
        {
            
            public double GetHostelBenefits();
        }
    }
}

