using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ISRPO
{
    public class I
    {
        public bool Insert(string namee, string price, string quantity, string sum)
        {
            DBEntities db = new DBEntities();
            try
            {
                Cash cash = new Cash();

                cash.Namee = namee;
                cash.Price = Convert.ToDecimal(price);
                cash.Quantity = quantity;
                cash.Sum = Convert.ToDecimal(sum);
                db.Cash.Add(cash);
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
