using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SimpleContactManager
{
    public class GravatarEmailConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string emailAddress = value as string;
            if (emailAddress == null)
            {
                return null;
            }

            byte[] emailHash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(emailAddress));
            string emailHashString = emailHash.Select(x => x.ToString("x2")).Aggregate((x, y) => x + y);

            return string.Format("http://www.gravatar.com/avatar/{0}?d=identicon&s=400", emailHashString);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
