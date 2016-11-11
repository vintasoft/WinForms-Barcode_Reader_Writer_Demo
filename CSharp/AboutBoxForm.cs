using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Vintasoft.Barcode;

namespace BarcodeDemo
{
    public partial class AboutBoxForm : Form
    {
        
        #region Constructors

        public AboutBoxForm()
        {
            InitializeComponent();
        }

        public AboutBoxForm(string productPrefix)
            :this()
        {
            nameLabel.Text = string.Format(nameLabel.Text, AssemblyTitle, AssemblyShortVersion);
            imagingSDKVersionLabel.Text = string.Format(imagingSDKVersionLabel.Text, AssemblyVersion);
            productLinkLabel.Text = string.Format(productLinkLabel.Text, productPrefix);
            productFAQLinkLabel.Text = string.Format(productFAQLinkLabel.Text, productPrefix);
        }

        #endregion



        #region Properties

        [Browsable(false)]
        public string AssemblyTitle
        {
            get
            {

                object[] attributes = Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        [Browsable(false)]
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetAssembly(typeof(IBarcodeInfo)).GetName().Version.ToString();
            }
        }

        [Browsable(false)]
        public string AssemblyShortVersion
        {
            get
            {
                Version ver = Assembly.GetAssembly(typeof(IBarcodeInfo)).GetName().Version;
                return string.Format("{0}.{1}", ver.Major, ver.Minor);
            }
        }     

        #endregion

        
        
        #region Methods

        protected override void OnLoad(EventArgs e)
        {
            Text = "About...";
            base.OnLoad(e);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(string.Format("http://{0}", ((LinkLabel)sender).Text));
        }

        private void vintasoftLogoPictureBox_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.vintasoft.com");
        }

        #endregion

    }
}
