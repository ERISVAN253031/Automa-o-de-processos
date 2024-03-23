using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Automoção
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            var chromium = new ChromiumWebBrowser("https://github.com/login");
            chromium.FrameLoadEnd += (send, args) =>
            {
                string script = @"document.querySelector('#login_field').value = 'vansales63@hotmail.com'
                                    document.querySelector('#password').value = 'Van25303131@';
                                    document.querySelector('#login > div.auth-form-body.mt-3 > form > div > input.btn.btn-primary.btn-block.js-sign-in-button').click(); ";


                args.Frame.ExecuteJavaScriptAsync(script);


            };



            painel.Controls.Clear();
            painel.Controls.Add(chromium);
        }

        private void btnLinkedin_Click(object sender, EventArgs e)
        {

            var chromium = new ChromiumWebBrowser("https://www.linkedin.com/home");
            chromium.FrameLoadEnd += (send, args) =>
            {
                string script = @"document.querySelector('#session_key').value = 'vansales63@hotmail.com'
                                    document.querySelector('#session_password').value = '25303131';
                                    document.querySelector('#main-content > section.section.min-h-\\[560px\\].flex-nowrap.pt-\\[40px\\].babybear\\:flex-col.babybear\\:min-h-\\[0\\].babybear\\:px-mobile-container-padding.babybear\\:pt-\\[24px\\] > div > div > form > div.flex.justify-between.sign-in-form__footer--full-width > button').click(); ";


                args.Frame.ExecuteJavaScriptAsync(script);


            };

            painel.Controls.Clear();
            painel.Controls.Add(chromium);
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            var chromium = new ChromiumWebBrowser("https://www.youtube.com/channel/UC-9-kyTW8ZkZNDHQJ6FgpwQ");
            chromium.FrameLoadEnd += (send, args) => { };




            painel.Controls.Clear();
            painel.Controls.Add(chromium);
        }


    }
}
