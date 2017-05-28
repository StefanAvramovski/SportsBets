namespace SportsBets
{
    partial class Form1
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
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstMatch = new System.Windows.Forms.ListBox();
            this.lstSelectedTeams = new System.Windows.Forms.ListBox();
            this.btnGenerateMatch = new System.Windows.Forms.Button();
            this.pbMatches = new System.Windows.Forms.ProgressBar();
            this.lblMatches = new System.Windows.Forms.Label();
            this.lblMatchTips = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCoef1 = new System.Windows.Forms.TextBox();
            this.txtCoefX = new System.Windows.Forms.TextBox();
            this.txtCoef2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.txtFullCoef = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.btnCreateNewTicket = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSnooker = new System.Windows.Forms.Button();
            this.btnTennis = new System.Windows.Forms.Button();
            this.btnHandball = new System.Windows.Forms.Button();
            this.btnBasketball = new System.Windows.Forms.Button();
            this.btnFootball = new System.Windows.Forms.Button();
            this.lblMatch = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(12, 132);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(226, 433);
            this.lstTeams.TabIndex = 0;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cabo Verde",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Curacao",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (see Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "England",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
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
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territories",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Sint Maarten",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "Uruguay",
            "Usa",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cbCountry.Location = new System.Drawing.Point(12, 92);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(226, 21);
            this.cbCountry.TabIndex = 1;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Одбери држава";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Одбери натпреварувач";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(273, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додади учесник";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(273, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Избриши учесник";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstMatch
            // 
            this.lstMatch.FormattingEnabled = true;
            this.lstMatch.Location = new System.Drawing.Point(480, 132);
            this.lstMatch.Name = "lstMatch";
            this.lstMatch.Size = new System.Drawing.Size(289, 342);
            this.lstMatch.TabIndex = 6;
            // 
            // lstSelectedTeams
            // 
            this.lstSelectedTeams.FormattingEnabled = true;
            this.lstSelectedTeams.Location = new System.Drawing.Point(273, 190);
            this.lstSelectedTeams.Name = "lstSelectedTeams";
            this.lstSelectedTeams.Size = new System.Drawing.Size(187, 43);
            this.lstSelectedTeams.TabIndex = 7;
            // 
            // btnGenerateMatch
            // 
            this.btnGenerateMatch.Location = new System.Drawing.Point(272, 423);
            this.btnGenerateMatch.Name = "btnGenerateMatch";
            this.btnGenerateMatch.Size = new System.Drawing.Size(187, 22);
            this.btnGenerateMatch.TabIndex = 8;
            this.btnGenerateMatch.Text = "Додади меч";
            this.btnGenerateMatch.UseVisualStyleBackColor = true;
            this.btnGenerateMatch.Click += new System.EventHandler(this.btnGenerateMatch_Click);
            // 
            // pbMatches
            // 
            this.pbMatches.Location = new System.Drawing.Point(480, 480);
            this.pbMatches.Name = "pbMatches";
            this.pbMatches.Size = new System.Drawing.Size(289, 23);
            this.pbMatches.TabIndex = 14;
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(460, 467);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(0, 13);
            this.lblMatches.TabIndex = 15;
            this.lblMatches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMatchTips
            // 
            this.lblMatchTips.AutoSize = true;
            this.lblMatchTips.Location = new System.Drawing.Point(317, 259);
            this.lblMatchTips.Name = "lblMatchTips";
            this.lblMatchTips.Size = new System.Drawing.Size(0, 13);
            this.lblMatchTips.TabIndex = 16;
            this.lblMatchTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Можни типови:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "1-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "X-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "2-";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(338, 323);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(35, 20);
            this.txtTip.TabIndex = 27;
            this.txtTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Внеси тип:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Натпревари";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCoef1
            // 
            this.txtCoef1.Location = new System.Drawing.Point(291, 289);
            this.txtCoef1.Name = "txtCoef1";
            this.txtCoef1.ReadOnly = true;
            this.txtCoef1.Size = new System.Drawing.Size(35, 20);
            this.txtCoef1.TabIndex = 32;
            this.txtCoef1.Text = "1.20";
            // 
            // txtCoefX
            // 
            this.txtCoefX.Location = new System.Drawing.Point(355, 289);
            this.txtCoefX.Name = "txtCoefX";
            this.txtCoefX.ReadOnly = true;
            this.txtCoefX.Size = new System.Drawing.Size(35, 20);
            this.txtCoefX.TabIndex = 33;
            this.txtCoefX.Text = "2.40";
            // 
            // txtCoef2
            // 
            this.txtCoef2.Location = new System.Drawing.Point(425, 289);
            this.txtCoef2.Name = "txtCoef2";
            this.txtCoef2.ReadOnly = true;
            this.txtCoef2.Size = new System.Drawing.Size(35, 20);
            this.txtCoef2.TabIndex = 34;
            this.txtCoef2.Text = "3.50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Уплата:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(477, 546);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Вкупен коефициент:";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(594, 513);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(149, 20);
            this.txtBid.TabIndex = 37;
            this.txtBid.Text = "20";
            this.txtBid.TextChanged += new System.EventHandler(this.txtBid_TextChanged);
            // 
            // txtFullCoef
            // 
            this.txtFullCoef.Location = new System.Drawing.Point(594, 539);
            this.txtFullCoef.Name = "txtFullCoef";
            this.txtFullCoef.ReadOnly = true;
            this.txtFullCoef.Size = new System.Drawing.Size(149, 20);
            this.txtFullCoef.TabIndex = 38;
            this.txtFullCoef.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Натпревар:";
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.Location = new System.Drawing.Point(274, 451);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(187, 23);
            this.btnDeleteMatch.TabIndex = 40;
            this.btnDeleteMatch.Text = "Избриши меч";
            this.btnDeleteMatch.UseVisualStyleBackColor = true;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // btnCreateNewTicket
            // 
            this.btnCreateNewTicket.Location = new System.Drawing.Point(563, 605);
            this.btnCreateNewTicket.Name = "btnCreateNewTicket";
            this.btnCreateNewTicket.Size = new System.Drawing.Size(206, 23);
            this.btnCreateNewTicket.TabIndex = 41;
            this.btnCreateNewTicket.Text = "Уплати тикет";
            this.btnCreateNewTicket.UseVisualStyleBackColor = true;
            this.btnCreateNewTicket.Click += new System.EventHandler(this.btnCreateNewTicket_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(477, 574);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Добивка:";
            // 
            // txtReward
            // 
            this.txtReward.Location = new System.Drawing.Point(594, 567);
            this.txtReward.Name = "txtReward";
            this.txtReward.ReadOnly = true;
            this.txtReward.Size = new System.Drawing.Size(149, 20);
            this.txtReward.TabIndex = 43;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Мажи",
            "Жени"});
            this.cbGender.Location = new System.Drawing.Point(480, 63);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(137, 21);
            this.cbGender.TabIndex = 44;
            this.cbGender.Visible = false;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(477, 47);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 13);
            this.lblGender.TabIndex = 45;
            this.lblGender.Text = "Избери пол";
            this.lblGender.Visible = false;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(12, 572);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(226, 23);
            this.btnDetails.TabIndex = 46;
            this.btnDetails.Text = "Подетални информации";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSnooker
            // 
            this.btnSnooker.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSnooker.Image = global::SportsBets.Properties.Resources.SnookerIcon;
            this.btnSnooker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnooker.Location = new System.Drawing.Point(632, 12);
            this.btnSnooker.Name = "btnSnooker";
            this.btnSnooker.Size = new System.Drawing.Size(137, 32);
            this.btnSnooker.TabIndex = 13;
            this.btnSnooker.Text = "Снукер";
            this.btnSnooker.UseVisualStyleBackColor = false;
            this.btnSnooker.Click += new System.EventHandler(this.btnSnooker_Click);
            // 
            // btnTennis
            // 
            this.btnTennis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTennis.Image = global::SportsBets.Properties.Resources.TennisIcon;
            this.btnTennis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTennis.Location = new System.Drawing.Point(480, 12);
            this.btnTennis.Name = "btnTennis";
            this.btnTennis.Size = new System.Drawing.Size(137, 32);
            this.btnTennis.TabIndex = 12;
            this.btnTennis.Text = "Тенис";
            this.btnTennis.UseVisualStyleBackColor = false;
            this.btnTennis.Click += new System.EventHandler(this.btnTennis_Click);
            // 
            // btnHandball
            // 
            this.btnHandball.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHandball.Image = global::SportsBets.Properties.Resources.HandballIcon;
            this.btnHandball.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHandball.Location = new System.Drawing.Point(324, 12);
            this.btnHandball.Name = "btnHandball";
            this.btnHandball.Size = new System.Drawing.Size(137, 32);
            this.btnHandball.TabIndex = 11;
            this.btnHandball.Text = "Ракомет";
            this.btnHandball.UseVisualStyleBackColor = false;
            this.btnHandball.Click += new System.EventHandler(this.btnHandball_Click);
            // 
            // btnBasketball
            // 
            this.btnBasketball.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBasketball.Image = global::SportsBets.Properties.Resources.BasketballIcon;
            this.btnBasketball.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasketball.Location = new System.Drawing.Point(170, 12);
            this.btnBasketball.Name = "btnBasketball";
            this.btnBasketball.Size = new System.Drawing.Size(137, 32);
            this.btnBasketball.TabIndex = 10;
            this.btnBasketball.Text = "Кошарка";
            this.btnBasketball.UseVisualStyleBackColor = false;
            this.btnBasketball.Click += new System.EventHandler(this.btnBasketball_Click);
            // 
            // btnFootball
            // 
            this.btnFootball.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFootball.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFootball.Image = global::SportsBets.Properties.Resources.FootballIcon;
            this.btnFootball.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFootball.Location = new System.Drawing.Point(12, 12);
            this.btnFootball.Name = "btnFootball";
            this.btnFootball.Size = new System.Drawing.Size(137, 32);
            this.btnFootball.TabIndex = 9;
            this.btnFootball.Text = "Фудбал";
            this.btnFootball.UseVisualStyleBackColor = false;
            this.btnFootball.Click += new System.EventHandler(this.btnFootball_Click);
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Location = new System.Drawing.Point(271, 255);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(47, 13);
            this.lblMatch.TabIndex = 47;
            this.lblMatch.Text = "lblMatch";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(477, 506);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 48;
            this.lblNumber.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 640);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtReward);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCreateNewTicket);
            this.Controls.Add(this.btnDeleteMatch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFullCoef);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCoef2);
            this.Controls.Add(this.txtCoefX);
            this.Controls.Add(this.txtCoef1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMatchTips);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.pbMatches);
            this.Controls.Add(this.btnSnooker);
            this.Controls.Add(this.btnTennis);
            this.Controls.Add(this.btnHandball);
            this.Controls.Add(this.btnBasketball);
            this.Controls.Add(this.btnFootball);
            this.Controls.Add(this.btnGenerateMatch);
            this.Controls.Add(this.lstSelectedTeams);
            this.Controls.Add(this.lstMatch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lstTeams);
            this.Name = "Form1";
            this.Text = "Креирај тикет";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstMatch;
        private System.Windows.Forms.ListBox lstSelectedTeams;
        private System.Windows.Forms.Button btnGenerateMatch;
        private System.Windows.Forms.Button btnFootball;
        private System.Windows.Forms.Button btnBasketball;
        private System.Windows.Forms.Button btnHandball;
        private System.Windows.Forms.Button btnTennis;
        private System.Windows.Forms.Button btnSnooker;
        private System.Windows.Forms.ProgressBar pbMatches;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Label lblMatchTips;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCoef2;
        private System.Windows.Forms.TextBox txtCoefX;
        private System.Windows.Forms.TextBox txtCoef1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFullCoef;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDeleteMatch;
        private System.Windows.Forms.TextBox txtReward;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCreateNewTicket;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lblNumber;

    }
}

