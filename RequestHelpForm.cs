﻿/*
Copyright 2009-2020 Intel Corporation

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeshAssistant
{
    public partial class RequestHelpForm : Form
    {
        public RequestHelpForm()
        {
            InitializeComponent();
        }

        public string helpRequestText { get { return mainTextBox.Text; } }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = (mainTextBox.Text.Length > 0);
        }

        private void RequestHelpForm_Load(object sender, EventArgs e)
        {
            mainTextBox.Focus();
        }
    }
}