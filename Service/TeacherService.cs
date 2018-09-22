using Model;
using RequestModel;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;
using Model.Repo;

namespace Service
{
    public class TeacherService : GenericService<Teacher, TeacherRequestModel, TeacherViewModel>
    {
        public TeacherService(IGenericRepository<Teacher> repository) : base(repository)
        {
        }
    }
}
