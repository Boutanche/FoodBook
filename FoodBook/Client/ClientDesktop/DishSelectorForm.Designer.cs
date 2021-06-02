
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
            this.tableLayoutPanel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_body
            // 
            this.tableLayoutPanel_body.ColumnCount = 2;
            this.tableLayoutPanel_body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_body.Controls.Add(this.tableLayoutPanel_Remember, 1, 0);
            this.tableLayoutPanel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_body.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_body.Name = "tableLayoutPanel_body";
            this.tableLayoutPanel_body.RowCount = 2;
            this.tableLayoutPanel_body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_body.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel_body.TabIndex = 0;
            // 
            // tableLayoutPanel_Remember
            // 
            this.tableLayoutPanel_Remember.ColumnCount = 2;
            this.tableLayoutPanel_Remember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Remember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Remember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Remember.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel_Remember.Name = "tableLayoutPanel_Remember";
            this.tableLayoutPanel_Remember.RowCount = 3;
            this.tableLayoutPanel_Remember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Remember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Remember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Remember.Size = new System.Drawing.Size(394, 54);
            this.tableLayoutPanel_Remember.TabIndex = 0;
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
            this.tableLayoutPanel_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_body;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Remember;
    }
}