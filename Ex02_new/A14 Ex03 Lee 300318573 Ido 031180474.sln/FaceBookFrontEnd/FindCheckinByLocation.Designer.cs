﻿namespace FaceBookFrontEnd
{
    partial class FindCheckinByLocationForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label nameLabel;
            this.insertLocationLbl = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.chooseDateLbl = new System.Windows.Forms.Label();
            this.dateTimePickerUser = new System.Windows.Forms.DateTimePicker();
            this.chooseDistanceLbl = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.listBoxAddressSuggestion = new System.Windows.Forms.ListBox();
            this.listBoxCheckinByPlace = new System.Windows.Forms.ListBox();
            this.checkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSortBy = new System.Windows.Forms.Label();
            this.labelMaxCount = new System.Windows.Forms.Label();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxCount = new System.Windows.Forms.ComboBox();
            this.linkLabelComments = new System.Windows.Forms.LinkLabel();
            this.linkLabelLikes = new System.Windows.Forms.LinkLabel();
            this.ButtonCheckin = new System.Windows.Forms.Button();
            this.listBoxViewCheckinLikes = new System.Windows.Forms.ListBox();
            this.listBoxViewCheckinComments = new System.Windows.Forms.ListBox();
            this.buttonFindLocation = new System.Windows.Forms.Button();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            imageNormalLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Location = new System.Drawing.Point(-73, 68);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(75, 13);
            imageNormalLabel.TabIndex = 2;
            imageNormalLabel.Text = "Image Normal:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(108, 41);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 13);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(108, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // insertLocationLbl
            // 
            this.insertLocationLbl.AutoSize = true;
            this.insertLocationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.insertLocationLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insertLocationLbl.Location = new System.Drawing.Point(12, 23);
            this.insertLocationLbl.Name = "insertLocationLbl";
            this.insertLocationLbl.Size = new System.Drawing.Size(92, 13);
            this.insertLocationLbl.TabIndex = 54;
            this.insertLocationLbl.Text = "Insert location:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxLocation.Location = new System.Drawing.Point(107, 20);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(231, 20);
            this.textBoxLocation.TabIndex = 55;
            this.textBoxLocation.Text = "location";
            // 
            // chooseDateLbl
            // 
            this.chooseDateLbl.AutoSize = true;
            this.chooseDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseDateLbl.Location = new System.Drawing.Point(12, 179);
            this.chooseDateLbl.Name = "chooseDateLbl";
            this.chooseDateLbl.Size = new System.Drawing.Size(78, 13);
            this.chooseDateLbl.TabIndex = 59;
            this.chooseDateLbl.Text = "Choose date";
            // 
            // dateTimePickerUser
            // 
            this.dateTimePickerUser.Location = new System.Drawing.Point(108, 177);
            this.dateTimePickerUser.Name = "dateTimePickerUser";
            this.dateTimePickerUser.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerUser.TabIndex = 60;
            // 
            // chooseDistanceLbl
            // 
            this.chooseDistanceLbl.AutoSize = true;
            this.chooseDistanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseDistanceLbl.Location = new System.Drawing.Point(12, 210);
            this.chooseDistanceLbl.Name = "chooseDistanceLbl";
            this.chooseDistanceLbl.Size = new System.Drawing.Size(169, 13);
            this.chooseDistanceLbl.TabIndex = 61;
            this.chooseDistanceLbl.Text = "Choose distance: (in Meters)";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxDistance.Location = new System.Drawing.Point(208, 203);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistance.TabIndex = 62;
            this.textBoxDistance.Text = "2000";
            // 
            // listBoxAddressSuggestion
            // 
            this.listBoxAddressSuggestion.BackColor = System.Drawing.Color.Bisque;
            this.listBoxAddressSuggestion.ForeColor = System.Drawing.Color.Black;
            this.listBoxAddressSuggestion.FormattingEnabled = true;
            this.listBoxAddressSuggestion.HorizontalScrollbar = true;
            this.listBoxAddressSuggestion.Location = new System.Drawing.Point(15, 50);
            this.listBoxAddressSuggestion.Name = "listBoxAddressSuggestion";
            this.listBoxAddressSuggestion.Size = new System.Drawing.Size(412, 121);
            this.listBoxAddressSuggestion.TabIndex = 63;
            this.listBoxAddressSuggestion.SelectedIndexChanged += new System.EventHandler(this.listBoxAddressSuggestion_SelectedIndexChanged);
            // 
            // listBoxCheckinByPlace
            // 
            this.listBoxCheckinByPlace.BackColor = System.Drawing.Color.Bisque;
            this.listBoxCheckinByPlace.DataSource = this.checkinBindingSource;
            this.listBoxCheckinByPlace.FormattingEnabled = true;
            this.listBoxCheckinByPlace.Location = new System.Drawing.Point(15, 240);
            this.listBoxCheckinByPlace.Name = "listBoxCheckinByPlace";
            this.listBoxCheckinByPlace.Size = new System.Drawing.Size(567, 95);
            this.listBoxCheckinByPlace.TabIndex = 64;
            this.listBoxCheckinByPlace.SelectedIndexChanged += new System.EventHandler(this.listBoxCheckinByPlace_SelectedIndexChanged);
            // 
            // checkinBindingSource
            // 
            this.checkinBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.BackColor = System.Drawing.SystemColors.Control;
            this.labelSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSortBy.Location = new System.Drawing.Point(327, 179);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(52, 13);
            this.labelSortBy.TabIndex = 70;
            this.labelSortBy.Text = "Sort By:";
            this.labelSortBy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMaxCount
            // 
            this.labelMaxCount.AutoSize = true;
            this.labelMaxCount.BackColor = System.Drawing.SystemColors.Control;
            this.labelMaxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMaxCount.Location = new System.Drawing.Point(327, 210);
            this.labelMaxCount.Name = "labelMaxCount";
            this.labelMaxCount.Size = new System.Drawing.Size(71, 13);
            this.labelMaxCount.TabIndex = 71;
            this.labelMaxCount.Text = "Max Count:";
            this.labelMaxCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.BackColor = System.Drawing.Color.White;
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "CreatedTime",
            "CommentsCount"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(404, 176);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSortBy.TabIndex = 72;
            // 
            // comboBoxMaxCount
            // 
            this.comboBoxMaxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxMaxCount.FormattingEnabled = true;
            this.comboBoxMaxCount.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "30"});
            this.comboBoxMaxCount.Location = new System.Drawing.Point(404, 207);
            this.comboBoxMaxCount.Name = "comboBoxMaxCount";
            this.comboBoxMaxCount.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaxCount.TabIndex = 73;
            // 
            // linkLabelComments
            // 
            this.linkLabelComments.AutoSize = true;
            this.linkLabelComments.Enabled = false;
            this.linkLabelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelComments.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabelComments.Location = new System.Drawing.Point(18, 360);
            this.linkLabelComments.Name = "linkLabelComments";
            this.linkLabelComments.Size = new System.Drawing.Size(144, 13);
            this.linkLabelComments.TabIndex = 74;
            this.linkLabelComments.TabStop = true;
            this.linkLabelComments.Text = "View checkin Comments";
            this.linkLabelComments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelComments_LinkClicked);
            // 
            // linkLabelLikes
            // 
            this.linkLabelLikes.AutoSize = true;
            this.linkLabelLikes.Enabled = false;
            this.linkLabelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelLikes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabelLikes.Location = new System.Drawing.Point(346, 360);
            this.linkLabelLikes.Name = "linkLabelLikes";
            this.linkLabelLikes.Size = new System.Drawing.Size(118, 13);
            this.linkLabelLikes.TabIndex = 75;
            this.linkLabelLikes.TabStop = true;
            this.linkLabelLikes.Text = "View Checkin Likes";
            this.linkLabelLikes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLikes_LinkClicked);
            // 
            // ButtonCheckin
            // 
            this.ButtonCheckin.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonCheckin.Enabled = false;
            this.ButtonCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonCheckin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ButtonCheckin.Location = new System.Drawing.Point(541, 168);
            this.ButtonCheckin.Name = "ButtonCheckin";
            this.ButtonCheckin.Size = new System.Drawing.Size(79, 62);
            this.ButtonCheckin.TabIndex = 77;
            this.ButtonCheckin.Text = "Gooo";
            this.ButtonCheckin.UseVisualStyleBackColor = false;
            this.ButtonCheckin.Click += new System.EventHandler(this.ButtonCheckin_Click);
            // 
            // listBoxViewCheckinLikes
            // 
            this.listBoxViewCheckinLikes.BackColor = System.Drawing.Color.Bisque;
            this.listBoxViewCheckinLikes.DisplayMember = "Comments";
            this.listBoxViewCheckinLikes.FormattingEnabled = true;
            this.listBoxViewCheckinLikes.HorizontalScrollbar = true;
            this.listBoxViewCheckinLikes.Location = new System.Drawing.Point(349, 376);
            this.listBoxViewCheckinLikes.Name = "listBoxViewCheckinLikes";
            this.listBoxViewCheckinLikes.ScrollAlwaysVisible = true;
            this.listBoxViewCheckinLikes.Size = new System.Drawing.Size(287, 121);
            this.listBoxViewCheckinLikes.TabIndex = 78;
            this.listBoxViewCheckinLikes.ValueMember = "Comments";
            this.listBoxViewCheckinLikes.Visible = false;
            // 
            // listBoxViewCheckinComments
            // 
            this.listBoxViewCheckinComments.BackColor = System.Drawing.Color.Bisque;
            this.listBoxViewCheckinComments.FormattingEnabled = true;
            this.listBoxViewCheckinComments.HorizontalScrollbar = true;
            this.listBoxViewCheckinComments.Location = new System.Drawing.Point(21, 376);
            this.listBoxViewCheckinComments.Name = "listBoxViewCheckinComments";
            this.listBoxViewCheckinComments.ScrollAlwaysVisible = true;
            this.listBoxViewCheckinComments.Size = new System.Drawing.Size(287, 121);
            this.listBoxViewCheckinComments.TabIndex = 79;
            this.listBoxViewCheckinComments.Visible = false;
            // 
            // buttonFindLocation
            // 
            this.buttonFindLocation.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFindLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFindLocation.Location = new System.Drawing.Point(344, 17);
            this.buttonFindLocation.Name = "buttonFindLocation";
            this.buttonFindLocation.Size = new System.Drawing.Size(95, 23);
            this.buttonFindLocation.TabIndex = 80;
            this.buttonFindLocation.Text = "Find location";
            this.buttonFindLocation.UseVisualStyleBackColor = false;
            this.buttonFindLocation.Click += new System.EventHandler(this.buttonFindLocation_Click);
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.checkinBindingSource;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(189, 38);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(145, 54);
            this.messageTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "From.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(189, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(145, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.checkinBindingSource, "From.ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(453, 240);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(102, 95);
            this.imageNormalPictureBox.TabIndex = 4;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Controls.Add(imageNormalLabel);
            this.panel1.Location = new System.Drawing.Point(453, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 95);
            this.panel1.TabIndex = 82;
            // 
            // FindCheckinByLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1094, 513);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonFindLocation);
            this.Controls.Add(this.listBoxViewCheckinComments);
            this.Controls.Add(this.listBoxViewCheckinLikes);
            this.Controls.Add(this.ButtonCheckin);
            this.Controls.Add(this.linkLabelLikes);
            this.Controls.Add(this.linkLabelComments);
            this.Controls.Add(this.comboBoxMaxCount);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.labelMaxCount);
            this.Controls.Add(this.labelSortBy);
            this.Controls.Add(this.listBoxCheckinByPlace);
            this.Controls.Add(this.listBoxAddressSuggestion);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.chooseDistanceLbl);
            this.Controls.Add(this.dateTimePickerUser);
            this.Controls.Add(this.chooseDateLbl);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.insertLocationLbl);
            this.Name = "FindCheckinByLocationForm";
            this.Text = "FindCheckinByLocation";
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insertLocationLbl;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label chooseDateLbl;
        private System.Windows.Forms.DateTimePicker dateTimePickerUser;
        private System.Windows.Forms.Label chooseDistanceLbl;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.ListBox listBoxAddressSuggestion;
        private System.Windows.Forms.ListBox listBoxCheckinByPlace;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.Label labelMaxCount;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.ComboBox comboBoxMaxCount;
        private System.Windows.Forms.LinkLabel linkLabelComments;
        private System.Windows.Forms.LinkLabel linkLabelLikes;
        private System.Windows.Forms.Button ButtonCheckin;
        private System.Windows.Forms.ListBox listBoxViewCheckinLikes;
        private System.Windows.Forms.ListBox listBoxViewCheckinComments;
        private System.Windows.Forms.Button buttonFindLocation;
        private System.Windows.Forms.BindingSource checkinBindingSource;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Panel panel1;
    }
}