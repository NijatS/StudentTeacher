using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StudentTeacher.Interfaces
{
    internal interface IService
    {
        public void Create();
        public void Show();

        public void GetById();

        public void Delete();

    }
}
