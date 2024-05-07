using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }

        public int StaffID { get; set; }

        public String StaffFullName { get; set; }

        public DateTime StaffDoB { get; set; }

        public string StaffEmail { get; set; }

        public string NINumber { get; set; }

        public double Salary { get; set; }

        public bool PresentInBuilding { get; set; }

    }
}