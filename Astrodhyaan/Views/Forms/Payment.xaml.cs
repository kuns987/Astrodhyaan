using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Astrodhyaan.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FormsControls.Base;

namespace Astrodhyaan.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Payment : TabbedPage
    {
        public UserMasterEntity UserDetail { get; set; }
        public Payment(UserMasterEntity userdetail)
        {
            InitializeComponent();
            BarTextColor = Color.White;
            BarBackgroundColor = Color.FromHex("#c8c7c8");
            UserDetail = userdetail;
        }
        protected override async void OnAppearing()
        {
            BindingContext = UserDetail;
        }
        private void btn100_Clicked(object sender, EventArgs e)
        {
            txtAmount.Text = "100";
            setorder("100", "0");
        }

        private void btn200_Clicked(object sender, EventArgs e)
        {
            txtAmount.Text = "200";
            setorder("200", "0");
        }

        private void btn500_Clicked(object sender, EventArgs e)
        {
            txtAmount.Text = "500";
            setorder("500", "0");
        }

        private void btn1000_Clicked(object sender, EventArgs e)
        {
            txtAmount.Text = "1000";
            setorder("1000", "0");
        }

        private void btn2000_Clicked(object sender, EventArgs e)
        {
            txtAmount.Text = "2000";
            setorder("2000", "0");
        }

        private void btn5000_Clicked(object sender, EventArgs e)
        {
            txtAmount.Text = "5000";
            setorder("5000", "0");
        }

        private void btn10000_Clicked(object sender, EventArgs e)
        {
            txtAmount.Text = "10000";
            setorder("10000", "0");
        }

        private void btn20000_Clicked(object sender, EventArgs e)
        {
            txtAmount.Text = "20000";
            setorder("20000", "0");
        }
       
        public string setorder(string val,string discountpercent)
        {
            decimal gst = Convert.ToDecimal(val) * (Convert.ToDecimal(18)/100);
            decimal points = Convert.ToDecimal(val) * (Convert.ToDecimal(0.25) / 100);
            decimal amountpayable = Convert.ToDecimal(val) + gst - Convert.ToDecimal(discountpercent);
            lblAmount.Text = val;
            lblGST.Text = gst.ToString("0.##");
            lblDiscount.Text = discountpercent;
            lblAmountPayable.Text = amountpayable.ToString("0.##");
            lblUsage.Text = val;
            lblPoints.Text = points.ToString("0.##");
            btnPayout.Text = "Checkout To Pay Rs "+lblAmountPayable.Text;
            return "";
        }                
        private void txtAmount_Unfocused(object sender, FocusEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmount.Text))
                setorder(txtAmount.Text, "0");
        }
    }
}