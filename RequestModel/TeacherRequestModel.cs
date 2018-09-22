using Common.RequestModel;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Common.ViewModel;

namespace RequestModel
{
    public class TeacherRequestModel : BaseRequestModel<Teacher>
    {
        public TeacherRequestModel(string keyword, string orderBy = "Modified", string isAscending = "False") : base(keyword, orderBy, isAscending)
        {
        }

        protected override Expression<Func<Teacher, bool>> GetExpression()
        {
            Keyword = Keyword.ToLower();
            ExpressionObj = x => x.Name.ToLower().Contains(Keyword) || x.Phone.ToLower().Contains(Keyword)|| x.Course.ToLower().Contains(Keyword);
            ExpressionObj = ExpressionObj.And(GenerateBaseEntityExpression());

            return ExpressionObj;
        }

        public override Expression<Func<Teacher, DropdownViewModel>> Dropdown()
        {
            return x => new DropdownViewModel() { Id = x.Id, Text = x.Name, Data = x };
        }
    }
}
