#region Apache License, Version 2.0
//
// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
//
#endregion

namespace NMaven.VisualStudio.Addin
{
    using System.Windows.Forms;

    partial class AddArtifactsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addArtifact = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.remoteTabPage = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.localTabPage = new System.Windows.Forms.TabPage();
            this.localListView = new System.Windows.Forms.ListView();
            this.ArtifactNameHeader = new System.Windows.Forms.ColumnHeader();
            this.versionHeader = new System.Windows.Forms.ColumnHeader();
            this.artifactTabControl = new System.Windows.Forms.TabControl();
            this.remoteTabPage.SuspendLayout();
            this.localTabPage.SuspendLayout();
            this.artifactTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // addArtifact
            // 
            this.addArtifact.Location = new System.Drawing.Point(299, 296);
            this.addArtifact.Margin = new System.Windows.Forms.Padding(2);
            this.addArtifact.Name = "addArtifact";
            this.addArtifact.Size = new System.Drawing.Size(83, 26);
            this.addArtifact.TabIndex = 1;
            this.addArtifact.Text = "&Add";
            this.addArtifact.UseVisualStyleBackColor = true;
            this.addArtifact.Click += new System.EventHandler(this.addArtifact_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 296);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // remoteTabPage
            // 
            this.remoteTabPage.Controls.Add(this.treeView1);
            this.remoteTabPage.Location = new System.Drawing.Point(4, 22);
            this.remoteTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.remoteTabPage.Name = "remoteTabPage";
            this.remoteTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.remoteTabPage.Size = new System.Drawing.Size(469, 249);
            this.remoteTabPage.TabIndex = 1;
            this.remoteTabPage.Text = "Remote";
            this.remoteTabPage.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(17, 15);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(438, 222);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // localTabPage
            // 
            this.localTabPage.Controls.Add(this.localListView);
            this.localTabPage.Location = new System.Drawing.Point(4, 22);
            this.localTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.localTabPage.Name = "localTabPage";
            this.localTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.localTabPage.Size = new System.Drawing.Size(469, 249);
            this.localTabPage.TabIndex = 0;
            this.localTabPage.Text = "Local";
            this.localTabPage.UseVisualStyleBackColor = true;
            // 
            // localListView
            // 
            this.localListView.BackgroundImageTiled = true;
            this.localListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ArtifactNameHeader,
            this.versionHeader});
            this.localListView.Location = new System.Drawing.Point(16, 15);
            this.localListView.Margin = new System.Windows.Forms.Padding(2);
            this.localListView.Name = "localListView";
            this.localListView.Size = new System.Drawing.Size(438, 220);
            this.localListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.localListView.TabIndex = 0;
            this.localListView.UseCompatibleStateImageBehavior = false;
            this.localListView.DoubleClick += new System.EventHandler(this.localListView_DoubleClick);
            // 
            // ArtifactNameHeader
            // 
            this.ArtifactNameHeader.Text = "Artifact Name";
            this.ArtifactNameHeader.Width = 240;
            // 
            // versionHeader
            // 
            this.versionHeader.Text = "Version";
            this.versionHeader.Width = 120;
            // 
            // artifactTabControl
            // 
            this.artifactTabControl.Controls.Add(this.localTabPage);
            this.artifactTabControl.Controls.Add(this.remoteTabPage);
            this.artifactTabControl.Location = new System.Drawing.Point(9, 10);
            this.artifactTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.artifactTabControl.Name = "artifactTabControl";
            this.artifactTabControl.SelectedIndex = 0;
            this.artifactTabControl.Size = new System.Drawing.Size(477, 275);
            this.artifactTabControl.TabIndex = 0;
            // 
            // AddArtifactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 336);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addArtifact);
            this.Controls.Add(this.artifactTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddArtifactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Maven Artifact";
            this.remoteTabPage.ResumeLayout(false);
            this.localTabPage.ResumeLayout(false);
            this.artifactTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addArtifact;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage remoteTabPage;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage localTabPage;
        private System.Windows.Forms.ListView localListView;
        private System.Windows.Forms.ColumnHeader ArtifactNameHeader;
        private System.Windows.Forms.ColumnHeader versionHeader;
        private System.Windows.Forms.TabControl artifactTabControl;
    }
}