namespace Bhajan.Motor
{
    partial class NewUserSurvey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserSurvey));
            this.Survey_ChurchDenomination = new System.Windows.Forms.TextBox();
            this.Survey_ChurchName = new System.Windows.Forms.TextBox();
            this.Survey_State = new System.Windows.Forms.TextBox();
            this.Survey_Town = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SurveyDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Survey_Country = new System.Windows.Forms.ComboBox();
            this.Survey_SharedBy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Survey_ChurchDenomination
            // 
            this.Survey_ChurchDenomination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Survey_ChurchDenomination.AutoCompleteCustomSource.AddRange(new string[] {
            "Assemblies of God (AG)",
            "Baptist World Alliance",
            "Calvary Chapel",
            "Believers Church",
            "Catholics",
            "Seventh-Day Adventists (SDA)",
            "Mormons",
            "Jehovah\'s Witnesses",
            "World Mission Society Church of God",
            "Methodist",
            "United Methodist",
            "Bethani Baptist",
            "Living Baptist",
            "Independent"});
            this.Survey_ChurchDenomination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Survey_ChurchDenomination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Survey_ChurchDenomination.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Survey_ChurchDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Survey_ChurchDenomination.Location = new System.Drawing.Point(21, 162);
            this.Survey_ChurchDenomination.Name = "Survey_ChurchDenomination";
            this.Survey_ChurchDenomination.Size = new System.Drawing.Size(532, 38);
            this.Survey_ChurchDenomination.TabIndex = 2;
            // 
            // Survey_ChurchName
            // 
            this.Survey_ChurchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Survey_ChurchName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Survey_ChurchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Survey_ChurchName.Location = new System.Drawing.Point(21, 93);
            this.Survey_ChurchName.Name = "Survey_ChurchName";
            this.Survey_ChurchName.Size = new System.Drawing.Size(532, 38);
            this.Survey_ChurchName.TabIndex = 1;
            // 
            // Survey_State
            // 
            this.Survey_State.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Survey_State.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Survey_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Survey_State.Location = new System.Drawing.Point(309, 230);
            this.Survey_State.Name = "Survey_State";
            this.Survey_State.Size = new System.Drawing.Size(244, 38);
            this.Survey_State.TabIndex = 4;
            // 
            // Survey_Town
            // 
            this.Survey_Town.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Survey_Town.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Survey_Town.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Survey_Town.Location = new System.Drawing.Point(21, 230);
            this.Survey_Town.Name = "Survey_Town";
            this.Survey_Town.Size = new System.Drawing.Size(252, 38);
            this.Survey_Town.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(373, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Activate सक्रिय गर्नुहोस्";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SurveyDescription
            // 
            this.SurveyDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurveyDescription.AutoSize = true;
            this.SurveyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyDescription.Location = new System.Drawing.Point(32, 4);
            this.SurveyDescription.Name = "SurveyDescription";
            this.SurveyDescription.Size = new System.Drawing.Size(521, 50);
            this.SurveyDescription.TabIndex = 8;
            this.SurveyDescription.Text = "कृपया, सफ्टवेयर सक्रिय गर्न तलको फारम भर्नुहोस्।\r\nPlease fill out the form below " +
    "to activate the software.";
            this.SurveyDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "मण्डलीको नाम  Name of the Church:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(17, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "सम्प्रदाय वा वर्ग  Denomination:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(17, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "शहर/नगर/गाउँ City/Town/Village:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(305, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "प्रदेश/राज्य Province/State:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(17, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "देश Country:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(20, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "How did you hear about this software?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(20, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "तपाईंले यो सफ्टवेयरको बारेमा कसरी सुन्नुभयो?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Survey_Country
            // 
            this.Survey_Country.DropDownHeight = 200;
            this.Survey_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Survey_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Survey_Country.FormattingEnabled = true;
            this.Survey_Country.IntegralHeight = false;
            this.Survey_Country.Items.AddRange(new object[] {
            "Nepal नेपाल",
            "United States",
            "Canada",
            "Afghanistan",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua and/or Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brazil",
            "British Indian Ocean Territory",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Christmas Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoros",
            "Congo",
            "Cook Islands",
            "Costa Rica",
            "Croatia (Hrvatska)",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecudaor",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Falkland Islands (Malvinas)",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "France",
            "France, Metropolitan",
            "French Guiana",
            "French Polynesia",
            "French Southern Territories",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Heard and Mc Donald Islands",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran (Islamic Republic of)",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, Democratic People\'s Republic of",
            "Korea, Republic of",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Lao People\'s Democratic Republic",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libyan Arab Jamahiriya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova, Republic of",
            "Monaco",
            "Mongolia",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Netherlands",
            "Netherlands Antilles",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfork Island",
            "Northern Mariana Islands",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Georgia South Sandwich Islands",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "St. Helena",
            "St. Pierre and Miquelon",
            "Sudan",
            "Suriname",
            "Svalbarn and Jan Mayen Islands",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syrian Arab Republic",
            "Taiwan",
            "Tajikistan",
            "Tanzania, United Republic of",
            "Thailand",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks and Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States minor outlying islands",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City State",
            "Venezuela",
            "Vietnam",
            "Virigan Islands (British)",
            "Virgin Islands (U.S.)",
            "Wallis and Futuna Islands",
            "Western Sahara",
            "Yemen",
            "Yugoslavia",
            "Zaire",
            "Zambia",
            "Zimbabwe"});
            this.Survey_Country.Location = new System.Drawing.Point(21, 306);
            this.Survey_Country.Name = "Survey_Country";
            this.Survey_Country.Size = new System.Drawing.Size(252, 37);
            this.Survey_Country.TabIndex = 5;
            // 
            // Survey_SharedBy
            // 
            this.Survey_SharedBy.DropDownHeight = 200;
            this.Survey_SharedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Survey_SharedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Survey_SharedBy.FormattingEnabled = true;
            this.Survey_SharedBy.IntegralHeight = false;
            this.Survey_SharedBy.Items.AddRange(new object[] {
            "साथीहरू | Friends",
            "सामाजिक संजाल  | Social Media",
            "कतै देखेपछि | Seen Somewhere",
            "गुगल खोजी  | Google Search",
            "अर्को चर्च |  Some Other Church",
            "मलाई वेबसाइट थाहा थियो | I knew the Website"});
            this.Survey_SharedBy.Location = new System.Drawing.Point(21, 402);
            this.Survey_SharedBy.Name = "Survey_SharedBy";
            this.Survey_SharedBy.Size = new System.Drawing.Size(532, 37);
            this.Survey_SharedBy.TabIndex = 6;
            // 
            // NewUserSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.Survey_SharedBy);
            this.Controls.Add(this.Survey_Country);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurveyDescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Survey_Town);
            this.Controls.Add(this.Survey_State);
            this.Controls.Add(this.Survey_ChurchName);
            this.Controls.Add(this.Survey_ChurchDenomination);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 550);
            this.MinimumSize = new System.Drawing.Size(600, 550);
            this.Name = "NewUserSurvey";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "स्वागत छ, लगभग तयार भयो!! Welcome, Almost Ready!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewUserSurvey_FormClosing);
            this.Load += new System.EventHandler(this.NewUserSurvey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Survey_ChurchDenomination;
        private System.Windows.Forms.TextBox Survey_ChurchName;
        private System.Windows.Forms.TextBox Survey_State;
        private System.Windows.Forms.TextBox Survey_Town;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SurveyDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Survey_Country;
        private System.Windows.Forms.ComboBox Survey_SharedBy;
    }
}