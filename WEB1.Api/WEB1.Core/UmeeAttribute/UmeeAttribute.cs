using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB1.Core.UmeeAttribute
{
    /// <summary>
    /// CreatedBy: NDHuy (20/04/2022)
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKey : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class NotEmpty : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class NotDuplicate : Attribute
    {
    }
}
