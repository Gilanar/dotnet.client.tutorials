/**
 * Copyright (c) 2007-2015, Kaazing Corporation. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Kaazing.Security;

namespace EchoDemo
{
    public partial class LoginDemoForm : Form
    {

        public string Username
        {
            get { return UsernameText.Text; }
        }

        public string Password
        {
            get { return PasswordText.Text; }
        }

        public LoginDemoForm()
        {
            InitializeComponent();
        }

    }
}
