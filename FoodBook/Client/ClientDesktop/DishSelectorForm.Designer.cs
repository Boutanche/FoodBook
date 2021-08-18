
namespace ClientDesktop
{
    partial class DishSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DishSelectorForm));
            this.tableLayoutPanel_body = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Remember = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker_ConvertWeekAndDayInDate = new System.Windows.Forms.DateTimePicker();
            this.labelService = new System.Windows.Forms.Label();
            this.labelWeekNumber = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.dataGridViewDishes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel_body.SuspendLayout();
            this.tableLayoutPanel_Remember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_body
            // 
            this.tableLayoutPanel_body.ColumnCount = 2;
            this.tableLayoutPanel_body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_body.Controls.Add(this.tableLayoutPanel_Remember, 1, 0);
            this.tableLayoutPanel_body.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel_body.Controls.Add(this.dataGridViewDishes, 1, 1);
            this.tableLayoutPanel_body.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_body.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_body.Name = "tableLayoutPanel_body";
            this.tableLayoutPanel_body.RowCount = 2;
            this.tableLayoutPanel_body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_body.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel_body.TabIndex = 0;
            // 
            // tableLayoutPanel_Remember
            // 
            this.tableLayoutPanel_Remember.ColumnCount = 2;
            this.tableLayoutPanel_Remember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Remember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Remember.Controls.Add(this.dateTimePicker_ConvertWeekAndDayInDate, 0, 0);
            this.tableLayoutPanel_Remember.Controls.Add(this.labelService, 0, 1);
            this.tableLayoutPanel_Remember.Controls.Add(this.labelWeekNumber, 1, 0);
            this.tableLayoutPanel_Remember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Remember.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel_Remember.Name = "tableLayoutPanel_Remember";
            this.tableLayoutPanel_Remember.RowCount = 3;
            this.tableLayoutPanel_Remember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Remember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Remember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Remember.Size = new System.Drawing.Size(394, 84);
            this.tableLayoutPanel_Remember.TabIndex = 0;
            // 
            // dateTimePicker_ConvertWeekAndDayInDate
            // 
            this.dateTimePicker_ConvertWeekAndDayInDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_ConvertWeekAndDayInDate.Enabled = false;
            this.dateTimePicker_ConvertWeekAndDayInDate.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker_ConvertWeekAndDayInDate.Name = "dateTimePicker_ConvertWeekAndDayInDate";
            this.dateTimePicker_ConvertWeekAndDayInDate.Size = new System.Drawing.Size(309, 23);
            this.dateTimePicker_ConvertWeekAndDayInDate.TabIndex = 0;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelService.Font = new System.Drawing.Font("Gotham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelService.ForeColor = System.Drawing.Color.Orange;
            this.labelService.Location = new System.Drawing.Point(3, 28);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(309, 28);
            this.labelService.TabIndex = 3;
            this.labelService.Text = "Service : ";
            this.labelService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWeekNumber
            // 
            this.labelWeekNumber.AutoSize = true;
            this.labelWeekNumber.Location = new System.Drawing.Point(318, 0);
            this.labelWeekNumber.Name = "labelWeekNumber";
            this.labelWeekNumber.Size = new System.Drawing.Size(70, 28);
            this.labelWeekNumber.TabIndex = 4;
            this.labelWeekNumber.Text = "WeekNumber";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Gotham Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.ForeColor = System.Drawing.Color.Orange;
            this.label_Title.Location = new System.Drawing.Point(3, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(394, 90);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Selecteur de plats :";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewDishes
            // 
            this.dataGridViewDishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDishes.Location = new System.Drawing.Point(403, 93);
            this.dataGridViewDishes.MultiSelect = false;
            this.dataGridViewDishes.Name = "dataGridViewDishes";
            this.dataGridViewDishes.ReadOnly = true;
            this.dataGridViewDishes.RowTemplate.Height = 25;
            this.dataGridViewDishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDishes.Size = new System.Drawing.Size(394, 354);
            this.dataGridViewDishes.TabIndex = 2;
            this.dataGridViewDishes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDishes_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button_ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DishSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel_body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DishSelectorForm";
            this.Text = "DishSelectorForm";
            this.Load += new System.EventHandler(this.DishSelectorForm_Load);
            this.tableLayoutPanel_body.ResumeLayout(false);
            this.tableLayoutPanel_body.PerformLayout();
            this.tableLayoutPanel_Remember.ResumeLayout(false);
            this.tableLayoutPanel_Remember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDishes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_body;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Remember;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ConvertWeekAndDayInDate;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.DataGridView dataGridViewDishes;
        private System.Windows.Forms.Label labelWeekNumber;
        private System.Windows.Forms.Button button1;
    }
}