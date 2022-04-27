using System.Collections;

namespace WEB1.Core.Exceptions
{
    public class UmeeValidateException:Exception
    {
        IDictionary UmeeData = new Dictionary<string, object>();
        public UmeeValidateException(object data)
        {
            this.UmeeData.Add("data", data);
        }

        public override string Message
        {
            get 
            {
                return Properties.Resources.ValidateException;
            }
        }

        public override IDictionary Data
        {
            get
            {
                return UmeeData;
            }
        }
    }
}
