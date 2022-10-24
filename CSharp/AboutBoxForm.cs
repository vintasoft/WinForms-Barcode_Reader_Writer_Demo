using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

using Vintasoft.Barcode;

namespace BarcodeDemo
{
    /// <summary>
    /// A form that shows information about application.
    /// </summary>
    public partial class AboutBoxForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutBoxForm"/> class.
        /// </summary>
        public AboutBoxForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutBoxForm"/> class.
        /// </summary>
        /// <param name="productPrefix">The product prefix.</param>
        public AboutBoxForm(string productPrefix)
            : this()
        {
            nameLabel.Text = string.Format(nameLabel.Text, AssemblyTitle, AssemblyShortVersion);
            imagingSDKVersionLabel.Text = string.Format(imagingSDKVersionLabel.Text, AssemblyVersion);
            productLinkLabel.Text = string.Format(productLinkLabel.Text, productPrefix);
            productFAQLinkLabel.Text = string.Format(productFAQLinkLabel.Text, productPrefix);
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the assembly title.
        /// </summary>
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

        /// <summary>
        /// Gets the assembly version.
        /// </summary>
        [Browsable(false)]
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetAssembly(typeof(IBarcodeInfo)).GetName().Version.ToString();
            }
        }

        /// <summary>
        /// Gets the assembly short version.
        /// </summary>
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

        /// <summary>
        /// Raises the System.Windows.Forms.Form.Load event.
        /// </summary>
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
            ProcessStartInfo processInfo = new ProcessStartInfo(string.Format("https://{0}", ((LinkLabel)sender).Text));
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

        private void vintasoftLogoPictureBox_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("https://www.vintasoft.com");
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

        #endregion

    }
}
