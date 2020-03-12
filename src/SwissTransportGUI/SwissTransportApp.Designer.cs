﻿namespace SwissTransportGUI
{
    partial class SwissTransportApp
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
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Lv_Connections = new System.Windows.Forms.ListView();
            this.cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Time = new System.Windows.Forms.TextBox();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Cb_ConnectionTo = new System.Windows.Forms.ComboBox();
            this.Lbl_ConnectionTo = new System.Windows.Forms.Label();
            this.Lbl_ConnectionFrom = new System.Windows.Forms.Label();
            this.Cb_ConnectionFrom = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Search_DepBoard = new System.Windows.Forms.Button();
            this.lv_DepartureBoard = new System.Windows.Forms.ListView();
            this.cDepTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lbl_ConectionsFromDepBoard = new System.Windows.Forms.Label();
            this.Cb_ConnectionsFromDepBoard = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Btn_Search_Map = new System.Windows.Forms.Button();
            this.Cb_Station_Map = new System.Windows.Forms.ComboBox();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_LocateMe = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btncreateemail = new System.Windows.Forms.Button();
            this.Lbl_Uhr = new System.Windows.Forms.Label();
            this.Tmr_Uhr = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(17, 31);
            this.Lbl_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(542, 91);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "Transport App";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tabControl1.Location = new System.Drawing.Point(19, 183);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(3021, 1302);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lv_Connections);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(10, 56);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(3001, 1236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search for a Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Lv_Connections
            // 
            this.Lv_Connections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDate,
            this.cDepartureTime,
            this.cDepartureStation,
            this.cArrivalStation,
            this.cArrivalTime,
            this.cDuration,
            this.cPlatform});
            this.Lv_Connections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Connections.HideSelection = false;
            this.Lv_Connections.Location = new System.Drawing.Point(639, 10);
            this.Lv_Connections.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Lv_Connections.Name = "Lv_Connections";
            this.Lv_Connections.Size = new System.Drawing.Size(2337, 1228);
            this.Lv_Connections.TabIndex = 8;
            this.Lv_Connections.TabStop = false;
            this.Lv_Connections.UseCompatibleStateImageBehavior = false;
            this.Lv_Connections.View = System.Windows.Forms.View.Details;
            // 
            // cDate
            // 
            this.cDate.Text = "Date";
            this.cDate.Width = 100;
            // 
            // cDepartureTime
            // 
            this.cDepartureTime.Text = "Departure Time";
            this.cDepartureTime.Width = 100;
            // 
            // cDepartureStation
            // 
            this.cDepartureStation.Text = "Departure Station";
            this.cDepartureStation.Width = 200;
            // 
            // cArrivalStation
            // 
            this.cArrivalStation.Text = "Arrival Station";
            this.cArrivalStation.Width = 200;
            // 
            // cArrivalTime
            // 
            this.cArrivalTime.Text = "Arrival Time";
            this.cArrivalTime.Width = 100;
            // 
            // cDuration
            // 
            this.cDuration.Text = "Duration";
            this.cDuration.Width = 100;
            // 
            // cPlatform
            // 
            this.cPlatform.Text = "Platform";
            this.cPlatform.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Time);
            this.groupBox2.Controls.Add(this.Lbl_Time);
            this.groupBox2.Controls.Add(this.Lbl_Date);
            this.groupBox2.Controls.Add(this.Dtp_Date);
            this.groupBox2.Location = new System.Drawing.Point(9, 457);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.groupBox2.Size = new System.Drawing.Size(618, 491);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detailed Options";
            // 
            // Txt_Time
            // 
            this.Txt_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Time.Location = new System.Drawing.Point(58, 283);
            this.Txt_Time.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Txt_Time.Name = "Txt_Time";
            this.Txt_Time.Size = new System.Drawing.Size(234, 46);
            this.Txt_Time.TabIndex = 7;
            this.Txt_Time.Text = "HH:mm";
            this.Txt_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Time.TextChanged += new System.EventHandler(this.Txt_Time_TextChanged);
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Location = new System.Drawing.Point(51, 240);
            this.Lbl_Time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(102, 39);
            this.Lbl_Time.TabIndex = 6;
            this.Lbl_Time.Text = "Time:";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(51, 88);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(98, 39);
            this.Lbl_Date.TabIndex = 5;
            this.Lbl_Date.Text = "Date:";
            // 
            // Dtp_Date
            // 
            this.Dtp_Date.Location = new System.Drawing.Point(58, 133);
            this.Dtp_Date.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Dtp_Date.Name = "Dtp_Date";
            this.Dtp_Date.Size = new System.Drawing.Size(484, 46);
            this.Dtp_Date.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Search);
            this.groupBox1.Controls.Add(this.Cb_ConnectionTo);
            this.groupBox1.Controls.Add(this.Lbl_ConnectionTo);
            this.groupBox1.Controls.Add(this.Lbl_ConnectionFrom);
            this.groupBox1.Controls.Add(this.Cb_ConnectionFrom);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(618, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for a Connection";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Btn_Search.Location = new System.Drawing.Point(58, 318);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(490, 54);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Cb_ConnectionTo
            // 
            this.Cb_ConnectionTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Cb_ConnectionTo.FormattingEnabled = true;
            this.Cb_ConnectionTo.Location = new System.Drawing.Point(58, 222);
            this.Cb_ConnectionTo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cb_ConnectionTo.Name = "Cb_ConnectionTo";
            this.Cb_ConnectionTo.Size = new System.Drawing.Size(484, 47);
            this.Cb_ConnectionTo.TabIndex = 3;
            this.Cb_ConnectionTo.TextUpdate += new System.EventHandler(this.Cb_ConnectionTo_TextUpdate);
            // 
            // Lbl_ConnectionTo
            // 
            this.Lbl_ConnectionTo.AutoSize = true;
            this.Lbl_ConnectionTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Lbl_ConnectionTo.Location = new System.Drawing.Point(51, 180);
            this.Lbl_ConnectionTo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_ConnectionTo.Name = "Lbl_ConnectionTo";
            this.Lbl_ConnectionTo.Size = new System.Drawing.Size(248, 39);
            this.Lbl_ConnectionTo.TabIndex = 2;
            this.Lbl_ConnectionTo.Text = "Connection To:";
            // 
            // Lbl_ConnectionFrom
            // 
            this.Lbl_ConnectionFrom.AutoSize = true;
            this.Lbl_ConnectionFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Lbl_ConnectionFrom.Location = new System.Drawing.Point(51, 53);
            this.Lbl_ConnectionFrom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_ConnectionFrom.Name = "Lbl_ConnectionFrom";
            this.Lbl_ConnectionFrom.Size = new System.Drawing.Size(287, 39);
            this.Lbl_ConnectionFrom.TabIndex = 1;
            this.Lbl_ConnectionFrom.Text = "Connection From:";
            // 
            // Cb_ConnectionFrom
            // 
            this.Cb_ConnectionFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Cb_ConnectionFrom.FormattingEnabled = true;
            this.Cb_ConnectionFrom.Location = new System.Drawing.Point(58, 96);
            this.Cb_ConnectionFrom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cb_ConnectionFrom.Name = "Cb_ConnectionFrom";
            this.Cb_ConnectionFrom.Size = new System.Drawing.Size(484, 47);
            this.Cb_ConnectionFrom.TabIndex = 0;
            this.Cb_ConnectionFrom.TextUpdate += new System.EventHandler(this.Cb_ConnectionFrom_TextUpdate);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_Search_DepBoard);
            this.tabPage2.Controls.Add(this.lv_DepartureBoard);
            this.tabPage2.Controls.Add(this.Lbl_ConectionsFromDepBoard);
            this.tabPage2.Controls.Add(this.Cb_ConnectionsFromDepBoard);
            this.tabPage2.Location = new System.Drawing.Point(10, 56);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Size = new System.Drawing.Size(3001, 1236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Departure Board";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_Search_DepBoard
            // 
            this.Btn_Search_DepBoard.Location = new System.Drawing.Point(548, 46);
            this.Btn_Search_DepBoard.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Btn_Search_DepBoard.Name = "Btn_Search_DepBoard";
            this.Btn_Search_DepBoard.Size = new System.Drawing.Size(490, 63);
            this.Btn_Search_DepBoard.TabIndex = 10;
            this.Btn_Search_DepBoard.Text = "Search";
            this.Btn_Search_DepBoard.UseVisualStyleBackColor = true;
            this.Btn_Search_DepBoard.Click += new System.EventHandler(this.Btn_Search_DepBoard_Click);
            // 
            // lv_DepartureBoard
            // 
            this.lv_DepartureBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDepTime,
            this.cDestination,
            this.cDesignation});
            this.lv_DepartureBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DepartureBoard.HideSelection = false;
            this.lv_DepartureBoard.Location = new System.Drawing.Point(19, 123);
            this.lv_DepartureBoard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lv_DepartureBoard.Name = "lv_DepartureBoard";
            this.lv_DepartureBoard.Size = new System.Drawing.Size(2958, 1146);
            this.lv_DepartureBoard.TabIndex = 9;
            this.lv_DepartureBoard.TabStop = false;
            this.lv_DepartureBoard.UseCompatibleStateImageBehavior = false;
            this.lv_DepartureBoard.View = System.Windows.Forms.View.Details;
            // 
            // cDepTime
            // 
            this.cDepTime.Text = "Departure";
            this.cDepTime.Width = 150;
            // 
            // cDestination
            // 
            this.cDestination.Text = "Destination";
            this.cDestination.Width = 200;
            // 
            // cDesignation
            // 
            this.cDesignation.Text = "Designation";
            this.cDesignation.Width = 150;
            // 
            // Lbl_ConectionsFromDepBoard
            // 
            this.Lbl_ConectionsFromDepBoard.AutoSize = true;
            this.Lbl_ConectionsFromDepBoard.Location = new System.Drawing.Point(12, 5);
            this.Lbl_ConectionsFromDepBoard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_ConectionsFromDepBoard.Name = "Lbl_ConectionsFromDepBoard";
            this.Lbl_ConectionsFromDepBoard.Size = new System.Drawing.Size(287, 39);
            this.Lbl_ConectionsFromDepBoard.TabIndex = 3;
            this.Lbl_ConectionsFromDepBoard.Text = "Connection From:";
            // 
            // Cb_ConnectionsFromDepBoard
            // 
            this.Cb_ConnectionsFromDepBoard.FormattingEnabled = true;
            this.Cb_ConnectionsFromDepBoard.Location = new System.Drawing.Point(19, 46);
            this.Cb_ConnectionsFromDepBoard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cb_ConnectionsFromDepBoard.Name = "Cb_ConnectionsFromDepBoard";
            this.Cb_ConnectionsFromDepBoard.Size = new System.Drawing.Size(484, 47);
            this.Cb_ConnectionsFromDepBoard.TabIndex = 2;
            this.Cb_ConnectionsFromDepBoard.TextUpdate += new System.EventHandler(this.Cb_ConnectionsFromDepBoard_TextUpdate);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Btn_Search_Map);
            this.tabPage3.Controls.Add(this.Cb_Station_Map);
            this.tabPage3.Controls.Add(this.Browser);
            this.tabPage3.Location = new System.Drawing.Point(10, 56);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tabPage3.Size = new System.Drawing.Size(3001, 1236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Station Map";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Btn_Search_Map
            // 
            this.Btn_Search_Map.Location = new System.Drawing.Point(1225, 230);
            this.Btn_Search_Map.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Btn_Search_Map.Name = "Btn_Search_Map";
            this.Btn_Search_Map.Size = new System.Drawing.Size(490, 54);
            this.Btn_Search_Map.TabIndex = 11;
            this.Btn_Search_Map.Text = "Search";
            this.Btn_Search_Map.UseVisualStyleBackColor = true;
            this.Btn_Search_Map.Click += new System.EventHandler(this.Btn_Search_Map_Click);
            // 
            // Cb_Station_Map
            // 
            this.Cb_Station_Map.FormattingEnabled = true;
            this.Cb_Station_Map.Location = new System.Drawing.Point(1225, 124);
            this.Cb_Station_Map.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cb_Station_Map.Name = "Cb_Station_Map";
            this.Cb_Station_Map.Size = new System.Drawing.Size(484, 47);
            this.Cb_Station_Map.TabIndex = 3;
            this.Cb_Station_Map.TextUpdate += new System.EventHandler(this.Cb_Station_Map_TextUpdate);
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(-163, -278);
            this.Browser.Margin = new System.Windows.Forms.Padding(4);
            this.Browser.MinimumSize = new System.Drawing.Size(29, 26);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(3329, 1524);
            this.Browser.TabIndex = 0;
            this.Browser.Url = new System.Uri("https://www.openstreetmap.org/#map=19/47.05010/8.31036&layers=T", System.UriKind.Absolute);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.Btn_LocateMe);
            this.tabPage4.Location = new System.Drawing.Point(10, 56);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(3001, 1236);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stations Near Me";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(550, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 46);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Your Location";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_LocateMe
            // 
            this.Btn_LocateMe.Location = new System.Drawing.Point(13, 12);
            this.Btn_LocateMe.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Btn_LocateMe.Name = "Btn_LocateMe";
            this.Btn_LocateMe.Size = new System.Drawing.Size(490, 54);
            this.Btn_LocateMe.TabIndex = 12;
            this.Btn_LocateMe.Text = "Locate Me";
            this.Btn_LocateMe.UseVisualStyleBackColor = true;
            this.Btn_LocateMe.Click += new System.EventHandler(this.Btn_LocateMe_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btncreateemail);
            this.tabPage5.Location = new System.Drawing.Point(10, 56);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(3001, 1236);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Email ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btncreateemail
            // 
            this.btncreateemail.Location = new System.Drawing.Point(31, 43);
            this.btncreateemail.Name = "btncreateemail";
            this.btncreateemail.Size = new System.Drawing.Size(321, 108);
            this.btncreateemail.TabIndex = 0;
            this.btncreateemail.Text = "Create Email";
            this.btncreateemail.UseVisualStyleBackColor = true;
            this.btncreateemail.Click += new System.EventHandler(this.Btncreateemail_Click);
            // 
            // Lbl_Uhr
            // 
            this.Lbl_Uhr.AutoSize = true;
            this.Lbl_Uhr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Uhr.Location = new System.Drawing.Point(2644, 31);
            this.Lbl_Uhr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Uhr.Name = "Lbl_Uhr";
            this.Lbl_Uhr.Size = new System.Drawing.Size(347, 91);
            this.Lbl_Uhr.TabIndex = 3;
            this.Lbl_Uhr.Text = "00:00:00";
            this.Lbl_Uhr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tmr_Uhr
            // 
            this.Tmr_Uhr.Enabled = true;
            this.Tmr_Uhr.Interval = 1000;
            this.Tmr_Uhr.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SwissTransportApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3021, 1483);
            this.Controls.Add(this.Lbl_Uhr);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Lbl_Name);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SwissTransportApp";
            this.Text = "SwissTransport App";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cb_ConnectionTo;
        private System.Windows.Forms.Label Lbl_ConnectionTo;
        private System.Windows.Forms.Label Lbl_ConnectionFrom;
        private System.Windows.Forms.ComboBox Cb_ConnectionFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.DateTimePicker Dtp_Date;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Lbl_Uhr;
        private System.Windows.Forms.Timer Tmr_Uhr;
        private System.Windows.Forms.Label Lbl_ConectionsFromDepBoard;
        private System.Windows.Forms.ComboBox Cb_ConnectionsFromDepBoard;
        private System.Windows.Forms.ListView Lv_Connections;
        private System.Windows.Forms.ColumnHeader cDate;
        private System.Windows.Forms.ColumnHeader cDepartureTime;
        private System.Windows.Forms.ColumnHeader cDepartureStation;
        private System.Windows.Forms.ColumnHeader cArrivalStation;
        private System.Windows.Forms.ColumnHeader cArrivalTime;
        private System.Windows.Forms.ColumnHeader cDuration;
        private System.Windows.Forms.ColumnHeader cPlatform;
        private System.Windows.Forms.TextBox Txt_Time;
        private System.Windows.Forms.ListView lv_DepartureBoard;
        private System.Windows.Forms.ColumnHeader cDepTime;
        private System.Windows.Forms.ColumnHeader cDestination;
        private System.Windows.Forms.Button Btn_Search_DepBoard;
        private System.Windows.Forms.ColumnHeader cDesignation;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.ComboBox Cb_Station_Map;
        private System.Windows.Forms.Button Btn_Search_Map;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Btn_LocateMe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btncreateemail;
    }
}

