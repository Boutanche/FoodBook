
namespace ClientDesktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_Title = new System.Windows.Forms.TableLayoutPanel();
            this.label_WeekNumber = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_week = new System.Windows.Forms.TextBox();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.tableLayoutPanel_btnMenuHeader = new System.Windows.Forms.TableLayoutPanel();
            this.button_status = new System.Windows.Forms.Button();
            this.button_createDish = new System.Windows.Forms.Button();
            this.tableLayoutPanel_MainBody = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Row2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_service1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_S1Formule = new System.Windows.Forms.TableLayoutPanel();
            this.label_S1Starter = new System.Windows.Forms.Label();
            this.label_S1Meal = new System.Windows.Forms.Label();
            this.label_S1Dessert = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Row3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_service2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_S2Formule = new System.Windows.Forms.TableLayoutPanel();
            this.label_S2Starter = new System.Windows.Forms.Label();
            this.label_S2Meal = new System.Windows.Forms.Label();
            this.label_S2Dessert = new System.Windows.Forms.Label();
            this.tableLayoutPanel_DaysHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label_day5 = new System.Windows.Forms.Label();
            this.label_day6 = new System.Windows.Forms.Label();
            this.label_day7 = new System.Windows.Forms.Label();
            this.label_day4 = new System.Windows.Forms.Label();
            this.label_day1 = new System.Windows.Forms.Label();
            this.label_day2 = new System.Windows.Forms.Label();
            this.label_day3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel_S1Body = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_S2Body = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.tableLayoutPanel_Title.SuspendLayout();
            this.tableLayoutPanel_btnMenuHeader.SuspendLayout();
            this.tableLayoutPanel_MainBody.SuspendLayout();
            this.tableLayoutPanel_Row2.SuspendLayout();
            this.tableLayoutPanel_S1Formule.SuspendLayout();
            this.tableLayoutPanel_Row3.SuspendLayout();
            this.tableLayoutPanel_S2Formule.SuspendLayout();
            this.tableLayoutPanel_DaysHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_MainBody, 0, 1);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1299, 641);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Logo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel_Title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel_btnMenuHeader, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1293, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Logo.Image = global::ClientDesktop.Properties.Resources.logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(74, 68);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // tableLayoutPanel_Title
            // 
            this.tableLayoutPanel_Title.ColumnCount = 3;
            this.tableLayoutPanel_Title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Title.Controls.Add(this.label_WeekNumber, 1, 0);
            this.tableLayoutPanel_Title.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel_Title.Controls.Add(this.textBox_week, 1, 1);
            this.tableLayoutPanel_Title.Controls.Add(this.button_previous, 0, 1);
            this.tableLayoutPanel_Title.Controls.Add(this.button_next, 2, 1);
            this.tableLayoutPanel_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Title.Location = new System.Drawing.Point(83, 3);
            this.tableLayoutPanel_Title.Name = "tableLayoutPanel_Title";
            this.tableLayoutPanel_Title.RowCount = 2;
            this.tableLayoutPanel_Title.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Title.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Title.Size = new System.Drawing.Size(1047, 68);
            this.tableLayoutPanel_Title.TabIndex = 1;
            // 
            // label_WeekNumber
            // 
            this.label_WeekNumber.AutoSize = true;
            this.label_WeekNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_WeekNumber.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_WeekNumber.ForeColor = System.Drawing.Color.Orange;
            this.label_WeekNumber.Location = new System.Drawing.Point(352, 0);
            this.label_WeekNumber.Name = "label_WeekNumber";
            this.label_WeekNumber.Size = new System.Drawing.Size(343, 34);
            this.label_WeekNumber.TabIndex = 1;
            this.label_WeekNumber.Text = "Semaine numéro :";
            this.label_WeekNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Gotham Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.ForeColor = System.Drawing.Color.Orange;
            this.label_Title.Location = new System.Drawing.Point(3, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(343, 34);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Composer vos menu :";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_week
            // 
            this.textBox_week.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_week.Enabled = false;
            this.textBox_week.Location = new System.Drawing.Point(473, 39);
            this.textBox_week.Name = "textBox_week";
            this.textBox_week.PlaceholderText = "xx";
            this.textBox_week.Size = new System.Drawing.Size(100, 23);
            this.textBox_week.TabIndex = 2;
            this.textBox_week.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_previous
            // 
            this.button_previous.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_previous.Location = new System.Drawing.Point(271, 39);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(75, 23);
            this.button_previous.TabIndex = 3;
            this.button_previous.Text = "<";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_next
            // 
            this.button_next.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_next.Location = new System.Drawing.Point(701, 39);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 4;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // tableLayoutPanel_btnMenuHeader
            // 
            this.tableLayoutPanel_btnMenuHeader.ColumnCount = 1;
            this.tableLayoutPanel_btnMenuHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_btnMenuHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_btnMenuHeader.Controls.Add(this.button_status, 0, 1);
            this.tableLayoutPanel_btnMenuHeader.Controls.Add(this.button_createDish, 0, 0);
            this.tableLayoutPanel_btnMenuHeader.Location = new System.Drawing.Point(1136, 3);
            this.tableLayoutPanel_btnMenuHeader.Name = "tableLayoutPanel_btnMenuHeader";
            this.tableLayoutPanel_btnMenuHeader.RowCount = 2;
            this.tableLayoutPanel_btnMenuHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_btnMenuHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_btnMenuHeader.Size = new System.Drawing.Size(154, 68);
            this.tableLayoutPanel_btnMenuHeader.TabIndex = 2;
            // 
            // button_status
            // 
            this.button_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_status.Location = new System.Drawing.Point(3, 37);
            this.button_status.Name = "button_status";
            this.button_status.Size = new System.Drawing.Size(148, 28);
            this.button_status.TabIndex = 1;
            this.button_status.Text = "Statistiques";
            this.button_status.UseVisualStyleBackColor = true;
            // 
            // button_createDish
            // 
            this.button_createDish.BackColor = System.Drawing.Color.PaleGreen;
            this.button_createDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_createDish.Location = new System.Drawing.Point(3, 3);
            this.button_createDish.Name = "button_createDish";
            this.button_createDish.Size = new System.Drawing.Size(148, 28);
            this.button_createDish.TabIndex = 0;
            this.button_createDish.Text = "Créer un plat";
            this.button_createDish.UseVisualStyleBackColor = false;
            this.button_createDish.Click += new System.EventHandler(this.button_createDish_Click);
            // 
            // tableLayoutPanel_MainBody
            // 
            this.tableLayoutPanel_MainBody.ColumnCount = 2;
            this.tableLayoutPanel_MainBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel_MainBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MainBody.Controls.Add(this.tableLayoutPanel_Row2, 0, 1);
            this.tableLayoutPanel_MainBody.Controls.Add(this.tableLayoutPanel_Row3, 0, 2);
            this.tableLayoutPanel_MainBody.Controls.Add(this.tableLayoutPanel_DaysHeader, 1, 0);
            this.tableLayoutPanel_MainBody.Controls.Add(this.tableLayoutPanel_S1Body, 1, 1);
            this.tableLayoutPanel_MainBody.Controls.Add(this.tableLayoutPanel_S2Body, 1, 2);
            this.tableLayoutPanel_MainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MainBody.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel_MainBody.Name = "tableLayoutPanel_MainBody";
            this.tableLayoutPanel_MainBody.RowCount = 3;
            this.tableLayoutPanel_MainBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_MainBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MainBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MainBody.Size = new System.Drawing.Size(1293, 555);
            this.tableLayoutPanel_MainBody.TabIndex = 1;
            // 
            // tableLayoutPanel_Row2
            // 
            this.tableLayoutPanel_Row2.ColumnCount = 2;
            this.tableLayoutPanel_Row2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Row2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Row2.Controls.Add(this.label_service1, 0, 0);
            this.tableLayoutPanel_Row2.Controls.Add(this.tableLayoutPanel_S1Formule, 1, 0);
            this.tableLayoutPanel_Row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Row2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel_Row2.Name = "tableLayoutPanel_Row2";
            this.tableLayoutPanel_Row2.RowCount = 1;
            this.tableLayoutPanel_Row2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Row2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Row2.Size = new System.Drawing.Size(104, 251);
            this.tableLayoutPanel_Row2.TabIndex = 0;
            // 
            // label_service1
            // 
            this.label_service1.AutoSize = true;
            this.label_service1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_service1.Font = new System.Drawing.Font("Gotham Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_service1.ForeColor = System.Drawing.Color.Orange;
            this.label_service1.Location = new System.Drawing.Point(3, 0);
            this.label_service1.Name = "label_service1";
            this.label_service1.Size = new System.Drawing.Size(46, 251);
            this.label_service1.TabIndex = 1;
            this.label_service1.Text = "Midi";
            this.label_service1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_S1Formule
            // 
            this.tableLayoutPanel_S1Formule.ColumnCount = 1;
            this.tableLayoutPanel_S1Formule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_S1Formule.Controls.Add(this.label_S1Starter, 0, 0);
            this.tableLayoutPanel_S1Formule.Controls.Add(this.label_S1Meal, 0, 1);
            this.tableLayoutPanel_S1Formule.Controls.Add(this.label_S1Dessert, 0, 2);
            this.tableLayoutPanel_S1Formule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_S1Formule.Location = new System.Drawing.Point(55, 3);
            this.tableLayoutPanel_S1Formule.Name = "tableLayoutPanel_S1Formule";
            this.tableLayoutPanel_S1Formule.RowCount = 3;
            this.tableLayoutPanel_S1Formule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S1Formule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S1Formule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S1Formule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_S1Formule.Size = new System.Drawing.Size(46, 245);
            this.tableLayoutPanel_S1Formule.TabIndex = 2;
            // 
            // label_S1Starter
            // 
            this.label_S1Starter.AutoSize = true;
            this.label_S1Starter.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_S1Starter.Location = new System.Drawing.Point(3, 0);
            this.label_S1Starter.Name = "label_S1Starter";
            this.label_S1Starter.Size = new System.Drawing.Size(32, 12);
            this.label_S1Starter.TabIndex = 0;
            this.label_S1Starter.Text = "Entrée";
            // 
            // label_S1Meal
            // 
            this.label_S1Meal.AutoSize = true;
            this.label_S1Meal.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_S1Meal.Location = new System.Drawing.Point(3, 81);
            this.label_S1Meal.Name = "label_S1Meal";
            this.label_S1Meal.Size = new System.Drawing.Size(21, 12);
            this.label_S1Meal.TabIndex = 1;
            this.label_S1Meal.Text = "Plat";
            // 
            // label_S1Dessert
            // 
            this.label_S1Dessert.AutoSize = true;
            this.label_S1Dessert.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_S1Dessert.Location = new System.Drawing.Point(3, 162);
            this.label_S1Dessert.Name = "label_S1Dessert";
            this.label_S1Dessert.Size = new System.Drawing.Size(36, 12);
            this.label_S1Dessert.TabIndex = 2;
            this.label_S1Dessert.Text = "Dessert";
            // 
            // tableLayoutPanel_Row3
            // 
            this.tableLayoutPanel_Row3.ColumnCount = 2;
            this.tableLayoutPanel_Row3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Row3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Row3.Controls.Add(this.label_service2, 0, 0);
            this.tableLayoutPanel_Row3.Controls.Add(this.tableLayoutPanel_S2Formule, 1, 0);
            this.tableLayoutPanel_Row3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Row3.Location = new System.Drawing.Point(3, 300);
            this.tableLayoutPanel_Row3.Name = "tableLayoutPanel_Row3";
            this.tableLayoutPanel_Row3.RowCount = 1;
            this.tableLayoutPanel_Row3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Row3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel_Row3.Size = new System.Drawing.Size(104, 252);
            this.tableLayoutPanel_Row3.TabIndex = 1;
            // 
            // label_service2
            // 
            this.label_service2.AutoSize = true;
            this.label_service2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_service2.Font = new System.Drawing.Font("Gotham Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_service2.ForeColor = System.Drawing.Color.Orange;
            this.label_service2.Location = new System.Drawing.Point(3, 0);
            this.label_service2.Name = "label_service2";
            this.label_service2.Size = new System.Drawing.Size(46, 252);
            this.label_service2.TabIndex = 1;
            this.label_service2.Text = "Soir";
            this.label_service2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_S2Formule
            // 
            this.tableLayoutPanel_S2Formule.ColumnCount = 1;
            this.tableLayoutPanel_S2Formule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_S2Formule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_S2Formule.Controls.Add(this.label_S2Starter, 0, 0);
            this.tableLayoutPanel_S2Formule.Controls.Add(this.label_S2Meal, 0, 1);
            this.tableLayoutPanel_S2Formule.Controls.Add(this.label_S2Dessert, 0, 2);
            this.tableLayoutPanel_S2Formule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_S2Formule.Location = new System.Drawing.Point(55, 3);
            this.tableLayoutPanel_S2Formule.Name = "tableLayoutPanel_S2Formule";
            this.tableLayoutPanel_S2Formule.RowCount = 3;
            this.tableLayoutPanel_S2Formule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S2Formule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S2Formule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S2Formule.Size = new System.Drawing.Size(46, 246);
            this.tableLayoutPanel_S2Formule.TabIndex = 2;
            // 
            // label_S2Starter
            // 
            this.label_S2Starter.AutoSize = true;
            this.label_S2Starter.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_S2Starter.Location = new System.Drawing.Point(3, 0);
            this.label_S2Starter.Name = "label_S2Starter";
            this.label_S2Starter.Size = new System.Drawing.Size(32, 12);
            this.label_S2Starter.TabIndex = 0;
            this.label_S2Starter.Text = "Entrée";
            // 
            // label_S2Meal
            // 
            this.label_S2Meal.AutoSize = true;
            this.label_S2Meal.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_S2Meal.Location = new System.Drawing.Point(3, 82);
            this.label_S2Meal.Name = "label_S2Meal";
            this.label_S2Meal.Size = new System.Drawing.Size(21, 12);
            this.label_S2Meal.TabIndex = 1;
            this.label_S2Meal.Text = "Plat";
            // 
            // label_S2Dessert
            // 
            this.label_S2Dessert.AutoSize = true;
            this.label_S2Dessert.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_S2Dessert.Location = new System.Drawing.Point(3, 164);
            this.label_S2Dessert.Name = "label_S2Dessert";
            this.label_S2Dessert.Size = new System.Drawing.Size(36, 12);
            this.label_S2Dessert.TabIndex = 2;
            this.label_S2Dessert.Text = "Dessert";
            // 
            // tableLayoutPanel_DaysHeader
            // 
            this.tableLayoutPanel_DaysHeader.ColumnCount = 7;
            this.tableLayoutPanel_DaysHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_DaysHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_DaysHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_DaysHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_DaysHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_DaysHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_DaysHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_DaysHeader.Controls.Add(this.label_day5, 0, 0);
            this.tableLayoutPanel_DaysHeader.Controls.Add(this.label_day6, 0, 0);
            this.tableLayoutPanel_DaysHeader.Controls.Add(this.label_day7, 0, 0);
            this.tableLayoutPanel_DaysHeader.Controls.Add(this.label_day4, 0, 0);
            this.tableLayoutPanel_DaysHeader.Controls.Add(this.label_day1, 0, 0);
            this.tableLayoutPanel_DaysHeader.Controls.Add(this.label_day2, 0, 0);
            this.tableLayoutPanel_DaysHeader.Controls.Add(this.label_day3, 0, 0);
            this.tableLayoutPanel_DaysHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_DaysHeader.Location = new System.Drawing.Point(113, 3);
            this.tableLayoutPanel_DaysHeader.Name = "tableLayoutPanel_DaysHeader";
            this.tableLayoutPanel_DaysHeader.RowCount = 1;
            this.tableLayoutPanel_DaysHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_DaysHeader.Size = new System.Drawing.Size(1177, 34);
            this.tableLayoutPanel_DaysHeader.TabIndex = 2;
            // 
            // label_day5
            // 
            this.label_day5.AutoSize = true;
            this.label_day5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_day5.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_day5.ForeColor = System.Drawing.Color.Orange;
            this.label_day5.Location = new System.Drawing.Point(675, 0);
            this.label_day5.Name = "label_day5";
            this.label_day5.Size = new System.Drawing.Size(162, 34);
            this.label_day5.TabIndex = 8;
            this.label_day5.Text = "Vendredi";
            this.label_day5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_day6
            // 
            this.label_day6.AutoSize = true;
            this.label_day6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_day6.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_day6.ForeColor = System.Drawing.Color.Orange;
            this.label_day6.Location = new System.Drawing.Point(843, 0);
            this.label_day6.Name = "label_day6";
            this.label_day6.Size = new System.Drawing.Size(162, 34);
            this.label_day6.TabIndex = 7;
            this.label_day6.Text = "Samedi";
            this.label_day6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_day7
            // 
            this.label_day7.AutoSize = true;
            this.label_day7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_day7.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_day7.ForeColor = System.Drawing.Color.Orange;
            this.label_day7.Location = new System.Drawing.Point(1011, 0);
            this.label_day7.Name = "label_day7";
            this.label_day7.Size = new System.Drawing.Size(163, 34);
            this.label_day7.TabIndex = 6;
            this.label_day7.Text = "Dimanche";
            this.label_day7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_day4
            // 
            this.label_day4.AutoSize = true;
            this.label_day4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_day4.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_day4.ForeColor = System.Drawing.Color.Orange;
            this.label_day4.Location = new System.Drawing.Point(507, 0);
            this.label_day4.Name = "label_day4";
            this.label_day4.Size = new System.Drawing.Size(162, 34);
            this.label_day4.TabIndex = 5;
            this.label_day4.Text = "Jeudi";
            this.label_day4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_day1
            // 
            this.label_day1.AutoSize = true;
            this.label_day1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_day1.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_day1.ForeColor = System.Drawing.Color.Orange;
            this.label_day1.Location = new System.Drawing.Point(3, 0);
            this.label_day1.Name = "label_day1";
            this.label_day1.Size = new System.Drawing.Size(162, 34);
            this.label_day1.TabIndex = 4;
            this.label_day1.Text = "Lundi";
            this.label_day1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_day2
            // 
            this.label_day2.AutoSize = true;
            this.label_day2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_day2.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_day2.ForeColor = System.Drawing.Color.Orange;
            this.label_day2.Location = new System.Drawing.Point(171, 0);
            this.label_day2.Name = "label_day2";
            this.label_day2.Size = new System.Drawing.Size(162, 34);
            this.label_day2.TabIndex = 3;
            this.label_day2.Text = "Mardi";
            this.label_day2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_day3
            // 
            this.label_day3.AutoSize = true;
            this.label_day3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_day3.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_day3.ForeColor = System.Drawing.Color.Orange;
            this.label_day3.Location = new System.Drawing.Point(339, 0);
            this.label_day3.Name = "label_day3";
            this.label_day3.Size = new System.Drawing.Size(162, 34);
            this.label_day3.TabIndex = 2;
            this.label_day3.Text = "Mercredi";
            this.label_day3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_S1Body
            // 
            this.tableLayoutPanel_S1Body.ColumnCount = 7;
            this.tableLayoutPanel_S1Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S1Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S1Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S1Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S1Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S1Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S1Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S1Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_S1Body.Location = new System.Drawing.Point(113, 43);
            this.tableLayoutPanel_S1Body.Name = "tableLayoutPanel_S1Body";
            this.tableLayoutPanel_S1Body.RowCount = 3;
            this.tableLayoutPanel_S1Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S1Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S1Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S1Body.Size = new System.Drawing.Size(1177, 251);
            this.tableLayoutPanel_S1Body.TabIndex = 3;
            // 
            // tableLayoutPanel_S2Body
            // 
            this.tableLayoutPanel_S2Body.ColumnCount = 7;
            this.tableLayoutPanel_S2Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S2Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S2Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S2Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S2Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S2Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S2Body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_S2Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_S2Body.Location = new System.Drawing.Point(113, 300);
            this.tableLayoutPanel_S2Body.Name = "tableLayoutPanel_S2Body";
            this.tableLayoutPanel_S2Body.RowCount = 3;
            this.tableLayoutPanel_S2Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S2Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S2Body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_S2Body.Size = new System.Drawing.Size(1177, 252);
            this.tableLayoutPanel_S2Body.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 641);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FoodBook Desktop";
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.tableLayoutPanel_Title.ResumeLayout(false);
            this.tableLayoutPanel_Title.PerformLayout();
            this.tableLayoutPanel_btnMenuHeader.ResumeLayout(false);
            this.tableLayoutPanel_MainBody.ResumeLayout(false);
            this.tableLayoutPanel_Row2.ResumeLayout(false);
            this.tableLayoutPanel_Row2.PerformLayout();
            this.tableLayoutPanel_S1Formule.ResumeLayout(false);
            this.tableLayoutPanel_S1Formule.PerformLayout();
            this.tableLayoutPanel_Row3.ResumeLayout(false);
            this.tableLayoutPanel_Row3.PerformLayout();
            this.tableLayoutPanel_S2Formule.ResumeLayout(false);
            this.tableLayoutPanel_S2Formule.PerformLayout();
            this.tableLayoutPanel_DaysHeader.ResumeLayout(false);
            this.tableLayoutPanel_DaysHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MainForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Title;
        private System.Windows.Forms.Label label_WeekNumber;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_week;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_btnMenuHeader;
        private System.Windows.Forms.Button button_createDish;
        private System.Windows.Forms.Button button_status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MainBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Row2;
        private System.Windows.Forms.Label label_service1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Row3;
        private System.Windows.Forms.Label label_service2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_S1Formule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_S2Formule;
        private System.Windows.Forms.Label label_S1Starter;
        private System.Windows.Forms.Label label_S1Meal;
        private System.Windows.Forms.Label label_S1Dessert;
        private System.Windows.Forms.Label label_S2Starter;
        private System.Windows.Forms.Label label_S2Meal;
        private System.Windows.Forms.Label label_S2Dessert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_DaysHeader;
        private System.Windows.Forms.Label label_day5;
        private System.Windows.Forms.Label label_day6;
        private System.Windows.Forms.Label label_day7;
        private System.Windows.Forms.Label label_day4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _day2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_day1;
        private System.Windows.Forms.Label label_day2;
        private System.Windows.Forms.Label label_day3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_S1Body;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_S2Body;
    }
}

