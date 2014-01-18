namespace BasicFacebookFeatures.WithSingltonAppSettings
{
    public partial class FacebookForm
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
            System.Windows.Forms.Label bioLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label linkToFacebookLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picture_smallPictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            this.FindFriendsCheckin = new System.Windows.Forms.Button();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.linkLabelCheckins = new System.Windows.Forms.LinkLabel();
            this.buttonSuggestFriends = new System.Windows.Forms.Button();
            this.linkLabelNewsFedds = new System.Windows.Forms.LinkLabel();
            this.panelFriendDetails = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.imageSquarePictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.imageSmallPictureBox = new System.Windows.Forms.PictureBox();
            this.linkToFacebookLinkLabel = new System.Windows.Forms.LinkLabel();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            bioLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            linkToFacebookLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelFriendDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bioLabel
            // 
            bioLabel.AutoSize = true;
            bioLabel.Location = new System.Drawing.Point(20, 63);
            bioLabel.Name = "bioLabel";
            bioLabel.Size = new System.Drawing.Size(25, 13);
            bioLabel.TabIndex = 0;
            bioLabel.Text = "Bio:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(20, 111);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(20, 131);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(20, 154);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(20, 180);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 10;
            userNameLabel.Text = "User Name:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(20, 85);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 13);
            messageLabel.TabIndex = 11;
            messageLabel.Text = "Message:";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // picture_smallPictureBox
            // 
            this.picture_smallPictureBox.Location = new System.Drawing.Point(1, 7);
            this.picture_smallPictureBox.Name = "picture_smallPictureBox";
            this.picture_smallPictureBox.Size = new System.Drawing.Size(200, 156);
            this.picture_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_smallPictureBox.TabIndex = 41;
            this.picture_smallPictureBox.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.HorizontalScrollbar = true;
            this.listBoxFriends.Location = new System.Drawing.Point(12, 261);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(189, 212);
            this.listBoxFriends.TabIndex = 37;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.HorizontalScrollbar = true;
            this.listBoxEvents.Location = new System.Drawing.Point(333, 527);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(236, 199);
            this.listBoxEvents.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(215, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Post Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(289, 9);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(971, 20);
            this.textBoxStatus.TabIndex = 45;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.Location = new System.Drawing.Point(1266, 7);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonSetStatus.TabIndex = 46;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNewsFeed.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxNewsFeed.DisplayMember = "name";
            this.listBoxNewsFeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.HorizontalScrollbar = true;
            this.listBoxNewsFeed.ItemHeight = 19;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(258, 69);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(868, 175);
            this.listBoxNewsFeed.TabIndex = 40;
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkFriends.Location = new System.Drawing.Point(12, 228);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(240, 30);
            this.linkFriends.TabIndex = 47;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends \r\n(Click on a friend to view it\'s picture and status)";
            this.linkFriends.UseCompatibleTextRendering = true;
            this.linkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.labelEvents.Location = new System.Drawing.Point(333, 494);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(190, 30);
            this.labelEvents.TabIndex = 48;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
            this.labelEvents.UseCompatibleTextRendering = true;
            this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            // 
            // FindFriendsCheckin
            // 
            this.FindFriendsCheckin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FindFriendsCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FindFriendsCheckin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FindFriendsCheckin.Location = new System.Drawing.Point(783, 264);
            this.FindFriendsCheckin.Name = "FindFriendsCheckin";
            this.FindFriendsCheckin.Size = new System.Drawing.Size(274, 23);
            this.FindFriendsCheckin.TabIndex = 50;
            this.FindFriendsCheckin.Text = "Find checkins by near location";
            this.FindFriendsCheckin.UseVisualStyleBackColor = false;
            this.FindFriendsCheckin.Click += new System.EventHandler(this.FindFriendsCheckin_Click);
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.HorizontalScrollbar = true;
            this.listBoxCheckins.Location = new System.Drawing.Point(12, 527);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(287, 199);
            this.listBoxCheckins.TabIndex = 51;
            // 
            // linkLabelCheckins
            // 
            this.linkLabelCheckins.AutoSize = true;
            this.linkLabelCheckins.Location = new System.Drawing.Point(9, 511);
            this.linkLabelCheckins.Name = "linkLabelCheckins";
            this.linkLabelCheckins.Size = new System.Drawing.Size(81, 13);
            this.linkLabelCheckins.TabIndex = 52;
            this.linkLabelCheckins.TabStop = true;
            this.linkLabelCheckins.Text = "Fetch Checkins";
            this.linkLabelCheckins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCheckins_LinkClicked);
            // 
            // buttonSuggestFriends
            // 
            this.buttonSuggestFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSuggestFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSuggestFriends.Location = new System.Drawing.Point(783, 305);
            this.buttonSuggestFriends.Name = "buttonSuggestFriends";
            this.buttonSuggestFriends.Size = new System.Drawing.Size(274, 23);
            this.buttonSuggestFriends.TabIndex = 53;
            this.buttonSuggestFriends.Text = "Suggest Friends by Photos or Events";
            this.buttonSuggestFriends.UseVisualStyleBackColor = true;
            this.buttonSuggestFriends.Click += new System.EventHandler(this.buttonSuggestFriends_Click);
            // 
            // linkLabelNewsFedds
            // 
            this.linkLabelNewsFedds.AutoSize = true;
            this.linkLabelNewsFedds.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkLabelNewsFedds.Location = new System.Drawing.Point(258, 32);
            this.linkLabelNewsFedds.Name = "linkLabelNewsFedds";
            this.linkLabelNewsFedds.Size = new System.Drawing.Size(257, 30);
            this.linkLabelNewsFedds.TabIndex = 56;
            this.linkLabelNewsFedds.TabStop = true;
            this.linkLabelNewsFedds.Text = "News Feeds \r\n(Click on a new feed to view comments and likes)\r\n";
            this.linkLabelNewsFedds.UseCompatibleTextRendering = true;
            this.linkLabelNewsFedds.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNewsFedds_LinkClicked);
            // 
            // panelFriendDetails
            // 
            this.panelFriendDetails.BackColor = System.Drawing.SystemColors.Info;
            this.panelFriendDetails.Controls.Add(messageLabel);
            this.panelFriendDetails.Controls.Add(this.messageTextBox);
            this.panelFriendDetails.Controls.Add(bioLabel);
            this.panelFriendDetails.Controls.Add(this.bioTextBox);
            this.panelFriendDetails.Controls.Add(birthdayLabel);
            this.panelFriendDetails.Controls.Add(this.birthdayTextBox);
            this.panelFriendDetails.Controls.Add(emailLabel);
            this.panelFriendDetails.Controls.Add(this.emailLinkLabel);
            this.panelFriendDetails.Controls.Add(this.imageSquarePictureBox);
            this.panelFriendDetails.Controls.Add(nameLabel);
            this.panelFriendDetails.Controls.Add(this.nameTextBox);
            this.panelFriendDetails.Controls.Add(userNameLabel);
            this.panelFriendDetails.Controls.Add(this.userNameTextBox);
            this.panelFriendDetails.Location = new System.Drawing.Point(231, 261);
            this.panelFriendDetails.Name = "panelFriendDetails";
            this.panelFriendDetails.Size = new System.Drawing.Size(535, 213);
            this.panelFriendDetails.TabIndex = 58;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusesBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(102, 86);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(326, 20);
            this.messageTextBox.TabIndex = 12;
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "Statuses";
            this.statusesBindingSource.DataSource = this.userBindingSource;
            // 
            // bioTextBox
            // 
            this.bioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Bio", true));
            this.bioTextBox.Location = new System.Drawing.Point(102, 60);
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.ReadOnly = true;
            this.bioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.bioTextBox.Size = new System.Drawing.Size(329, 20);
            this.bioTextBox.TabIndex = 1;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(102, 108);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.ReadOnly = true;
            this.birthdayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.birthdayTextBox.Size = new System.Drawing.Size(329, 20);
            this.birthdayTextBox.TabIndex = 3;
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLinkLabel.Location = new System.Drawing.Point(102, 131);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLinkLabel.TabIndex = 5;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "linkLabel1";
            // 
            // imageSquarePictureBox
            // 
            this.imageSquarePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageSquare", true));
            this.imageSquarePictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageSquarePictureBox.Name = "imageSquarePictureBox";
            this.imageSquarePictureBox.Size = new System.Drawing.Size(100, 50);
            this.imageSquarePictureBox.TabIndex = 7;
            this.imageSquarePictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(102, 151);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.nameTextBox.Size = new System.Drawing.Size(329, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(102, 177);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.userNameTextBox.Size = new System.Drawing.Size(329, 20);
            this.userNameTextBox.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(endTimeLabel);
            this.panel1.Controls.Add(this.endTimeTextBox);
            this.panel1.Controls.Add(this.imageSmallPictureBox);
            this.panel1.Controls.Add(linkToFacebookLabel);
            this.panel1.Controls.Add(this.linkToFacebookLinkLabel);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.locationTextBox);
            this.panel1.Controls.Add(startTimeLabel);
            this.panel1.Controls.Add(this.startTimeTextBox);
            this.panel1.Location = new System.Drawing.Point(591, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 197);
            this.panel1.TabIndex = 59;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 63);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(106, 60);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(332, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(3, 115);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true));
            this.endTimeTextBox.Location = new System.Drawing.Point(106, 112);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.ReadOnly = true;
            this.endTimeTextBox.Size = new System.Drawing.Size(332, 20);
            this.endTimeTextBox.TabIndex = 3;
            // 
            // imageSmallPictureBox
            // 
            this.imageSmallPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageSmall", true));
            this.imageSmallPictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageSmallPictureBox.Name = "imageSmallPictureBox";
            this.imageSmallPictureBox.Size = new System.Drawing.Size(100, 50);
            this.imageSmallPictureBox.TabIndex = 5;
            this.imageSmallPictureBox.TabStop = false;
            // 
            // linkToFacebookLabel
            // 
            linkToFacebookLabel.AutoSize = true;
            linkToFacebookLabel.Location = new System.Drawing.Point(3, 143);
            linkToFacebookLabel.Name = "linkToFacebookLabel";
            linkToFacebookLabel.Size = new System.Drawing.Size(97, 13);
            linkToFacebookLabel.TabIndex = 6;
            linkToFacebookLabel.Text = "Link To Facebook:";
            // 
            // linkToFacebookLinkLabel
            // 
            this.linkToFacebookLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLinkLabel.Location = new System.Drawing.Point(106, 143);
            this.linkToFacebookLinkLabel.Name = "linkToFacebookLinkLabel";
            this.linkToFacebookLinkLabel.Size = new System.Drawing.Size(145, 23);
            this.linkToFacebookLinkLabel.TabIndex = 7;
            this.linkToFacebookLinkLabel.TabStop = true;
            this.linkToFacebookLinkLabel.Text = "linkLabel1";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(3, 172);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(106, 169);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(332, 20);
            this.locationTextBox.TabIndex = 9;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(3, 88);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 10;
            startTimeLabel.Text = "Start Time:";
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.startTimeTextBox.Location = new System.Drawing.Point(106, 85);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.ReadOnly = true;
            this.startTimeTextBox.Size = new System.Drawing.Size(332, 20);
            this.startTimeTextBox.TabIndex = 11;
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFriendDetails);
            this.Controls.Add(this.linkLabelNewsFedds);
            this.Controls.Add(this.buttonSuggestFriends);
            this.Controls.Add(this.linkLabelCheckins);
            this.Controls.Add(this.listBoxCheckins);
            this.Controls.Add(this.FindFriendsCheckin);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.linkFriends);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picture_smallPictureBox);
            this.Controls.Add(this.listBoxNewsFeed);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Name = "FacebookForm";
            this.Text = "Welcom to Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelFriendDetails.ResumeLayout(false);
            this.panelFriendDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_smallPictureBox;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.Button FindFriendsCheckin;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.LinkLabel linkLabelCheckins;
        private System.Windows.Forms.Button buttonSuggestFriends;
        private System.Windows.Forms.LinkLabel linkLabelNewsFedds;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panelFriendDetails;
        private System.Windows.Forms.TextBox bioTextBox;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.PictureBox imageSquarePictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.PictureBox imageSmallPictureBox;
        private System.Windows.Forms.LinkLabel linkToFacebookLinkLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
    }
}
